using System;

namespace _2PC.Coordinator.DTO
{
    public class CommitUpdateCustomer
    {
        public Guid TransactionId { get; set; }

        public double Fondo { get; set; }
    }
}
