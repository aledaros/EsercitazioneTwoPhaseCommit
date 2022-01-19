using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITS.CLOD.TwoPhaseCommit.Event.Enteties
{

    [Table("Order")]
    public class Order
    {
        [Key]
        public int Id { get; set; }

        public int Qty { get; set; }

        public double Price { get; set; }


    }
}
