using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITS.CLOD.TwoPhaseCommit.Event.Event
{
    public class PrepareUpdateOrderEvent
    {
        public Guid TransactionId { get; set; }

        public int OrderId { get; set; }

        public int Qty { get; set; }

        public double Price { get; set; }

        const TransactionType _TransactionType = TransactionType.Order;

        public PrepareUpdateOrderEvent(Guid transactionId, int orderId, int qty, double price)
        {
            TransactionId=transactionId;
            OrderId=orderId;
            Qty=qty;
            Price=price;
        }
    }
}
