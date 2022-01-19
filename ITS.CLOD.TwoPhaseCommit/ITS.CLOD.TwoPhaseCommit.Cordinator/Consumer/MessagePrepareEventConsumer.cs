using ITS.CLOD.TwoPhaseCommit.Event.Event;
using MassTransit;

namespace ITS.CLOD.TwoPhaseCommit.Cordinator.Consumer
{
    public class MessagePrepareEventConsumer : IConsumer<MessagePrepareEvent>
    {
        public Task Consume(ConsumeContext<MessagePrepareEvent> context)
        {
            throw new NotImplementedException();
        }
    }
}
