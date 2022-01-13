using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _2PC.Customer.DTO
{
    public class Ack
    {
        public Guid TransactionId { get; set; }
        public bool Done { get; set; }

    }
}
