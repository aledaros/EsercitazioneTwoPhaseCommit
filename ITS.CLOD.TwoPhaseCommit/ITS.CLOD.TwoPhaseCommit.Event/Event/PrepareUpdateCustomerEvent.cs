using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITS.CLOD.TwoPhaseCommit.Event.Event
{
    public class PrepareUpdateCustomerEvent
    {
        public Guid TransactionId { get; set; }

        public double Fund { get; set; }

        public int CustomerId { get; set; }

        const TransactionType transactionType = TransactionType.Customer;

        public PrepareUpdateCustomerEvent(Guid transactionId, double fund, int customerId)
        {
            TransactionId=transactionId;
            Fund=fund;
            CustomerId=customerId;
        }
    }
}
