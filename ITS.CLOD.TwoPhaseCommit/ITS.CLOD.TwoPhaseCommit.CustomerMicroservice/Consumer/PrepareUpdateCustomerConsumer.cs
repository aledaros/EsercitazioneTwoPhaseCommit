using ITS.CLOD.TwoPhaseCommit.Event.Event;
using MassTransit;

namespace ITS.CLOD.TwoPhaseCommit.CustomerMicroservice.Consumer
{
    public class PrepareUpdateCustomerConsumer : IConsumer<PrepareUpdateCustomerEvent>
    {
        public int MyProperty { get; set; }
        public PrepareUpdateCustomerConsumer()
        {
            
        }

        public Task Consume(ConsumeContext<PrepareUpdateCustomerEvent> context)
        {
            
        }
    }
}
