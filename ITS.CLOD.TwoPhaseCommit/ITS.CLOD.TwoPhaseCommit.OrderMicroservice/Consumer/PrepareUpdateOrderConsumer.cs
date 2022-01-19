using ITS.CLOD.TwoPhaseCommit.Event;
using ITS.CLOD.TwoPhaseCommit.Event.Enteties;
using ITS.CLOD.TwoPhaseCommit.Event.Event;
using ITS.CLOD.TwoPhaseCommit.OrderMicroservice.Service;
using MassTransit;

namespace ITS.CLOD.TwoPhaseCommit.OrderMicroservice.Consumer
{
    public class PrepareUpdateOrderConsumer : IConsumer<PrepareUpdateOrderEvent>
    {
        public readonly OrderService _orderService;
        public readonly IPublishEndpoint _endpoint;
        public PrepareUpdateOrderConsumer(OrderService orderService, IPublishEndpoint endpoint)
        {
            _orderService=orderService;
            _endpoint=endpoint;
        }
        public async Task Consume(ConsumeContext<PrepareUpdateOrderEvent> context)
        {
            Order order = null;
            if(context.Message != null)
            {
                order= _orderService.Getorder(context.Message.OrderId);
            }
            if (order == null)
            {
                await _endpoint.Publish(new MessagePrepareEvent(context.Message.TransactionId, "Not ready", TransactionType.Order));
            }
            else
            {
                await _endpoint.Publish(new MessagePrepareEvent(context.Message.TransactionId, "Ready", TransactionType.Order));
            }
        }
    }
}
