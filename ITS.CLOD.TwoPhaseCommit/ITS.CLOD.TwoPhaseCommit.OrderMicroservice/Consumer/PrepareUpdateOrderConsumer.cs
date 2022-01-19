using ITS.CLOD.TwoPhaseCommit.Event.Event;
using MassTransit;

namespace ITS.CLOD.TwoPhaseCommit.OrderMicroservice.Consumer
{
    public class PrepareUpdateOrderConsumer : IConsumer<PrepareUpdateOrderEvent>
    {
        public Task Consume(ConsumeContext<PrepareUpdateOrderEvent> context)
        {
            throw new NotImplementedException();
        }
    }
}
