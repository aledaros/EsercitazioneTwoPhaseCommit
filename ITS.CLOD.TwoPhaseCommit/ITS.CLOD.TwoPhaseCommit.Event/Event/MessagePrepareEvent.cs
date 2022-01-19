using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITS.CLOD.TwoPhaseCommit.Event.Event
{
    public class MessagePrepareEvent
    {
        public Guid TransactionId { get; set; }
        public string Message { get; set; }

        public TransactionType TransactionType;

        public MessagePrepareEvent(Guid transactionId, string message, TransactionType transactionType)
        {
            TransactionId=transactionId;
            Message=message;
            TransactionType=transactionType;
        }
    }
}
