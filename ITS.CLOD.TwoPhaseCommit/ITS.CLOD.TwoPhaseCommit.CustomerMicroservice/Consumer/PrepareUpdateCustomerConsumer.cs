using ITS.CLOD.TwoPhaseCommit.CustomerMicroservice.Service;
using ITS.CLOD.TwoPhaseCommit.Event.Enteties;
using ITS.CLOD.TwoPhaseCommit.Event.Event;
using MassTransit;

namespace ITS.CLOD.TwoPhaseCommit.CustomerMicroservice.Consumer
{
    public class PrepareUpdateCustomerConsumer : IConsumer<PrepareUpdateCustomerEvent>
    {
        public readonly CustomerService _customerService;

        public PrepareUpdateCustomerConsumer(CustomerService customerService)
        {
            _customerService=customerService;
        }

        public Task Consume(ConsumeContext<PrepareUpdateCustomerEvent> context)
        {
            Customer customer = null;
            if (context.Message != null)
            {
                customer= _customerService.GetCustomer(context.Message.CustomerId);
            }
            
        }
    }
}
