using ITS.CLOD.TwoPhaseCommit.Event.Event;
using MassTransit;

namespace ITS.CLOD.TwoPhaseCommit.CustomerMicroservice.Consumer
{
    public class PrepareUpdateCustomerConsumer : IConsumer<PrepareUpdateCustomerEvent>
    {
        public Task Consume(ConsumeContext<PrepareUpdateCustomerEvent> context)
        {
            throw new NotImplementedException();
        }
    }
}
