using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITS.CLOD.TwoPhaseCommit.Event.Enteties
{
    [Table("Customer")]
    public class Customer
    {
        [Key]
        public int Id { get; set; }

        public double Fund { get; set; }
    }
}
