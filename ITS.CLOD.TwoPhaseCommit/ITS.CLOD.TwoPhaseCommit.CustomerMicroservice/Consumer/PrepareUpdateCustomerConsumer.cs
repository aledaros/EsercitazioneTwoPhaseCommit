using ITS.CLOD.TwoPhaseCommit.CustomerMicroservice.Service;
using ITS.CLOD.TwoPhaseCommit.Event;
using ITS.CLOD.TwoPhaseCommit.Event.Enteties;
using ITS.CLOD.TwoPhaseCommit.Event.Event;
using MassTransit;

namespace ITS.CLOD.TwoPhaseCommit.CustomerMicroservice.Consumer
{
    public class PrepareUpdateCustomerConsumer : IConsumer<PrepareUpdateCustomerEvent>
    {
        public readonly CustomerService _customerService;
        public readonly IPublishEndpoint _endpoint;
        public PrepareUpdateCustomerConsumer(CustomerService customerService, IPublishEndpoint endpoint)
        {
            _customerService=customerService;
            _endpoint=endpoint;
        }


        public async Task Consume(ConsumeContext<PrepareUpdateCustomerEvent> context)
        {
            Customer customer = null;
            if (context.Message != null)
            {
                customer= _customerService.GetCustomer(context.Message.CustomerId);
            }
            if (customer == null)
            {
                await _endpoint.Publish(new MessagePrepareEvent(context.Message.TransactionId, "Not ready", TransactionType.Customer));
            }
            else
            {
                await _endpoint.Publish(new MessagePrepareEvent(context.Message.TransactionId, "Ready", TransactionType.Customer));
            }

        }
    }
}
