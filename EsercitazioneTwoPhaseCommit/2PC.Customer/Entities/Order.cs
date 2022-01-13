using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _2PC.Customer.Entities
{
    public class Order
    {
        public Guid Guid { get; set; }

        public double Price { get; set; }
        public int Quantity { get; set; }

    }
}
