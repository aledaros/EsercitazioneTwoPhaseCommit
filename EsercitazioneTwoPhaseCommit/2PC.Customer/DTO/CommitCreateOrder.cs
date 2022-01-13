using System;

namespace _2PC.Coordinator.DTO
{
    public class CommitCreateOrder
    {
        public Guid Guid { get; set; }

        public int Qty { get; set; }

        public double Price { get; set; }
    }
}
