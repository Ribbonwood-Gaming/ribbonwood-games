using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ribbonwood.Models
{
    public class Order
    {
        public int ID { get; set; }
        public string Status { get; set; }
        public DateTime Date { get; set; }

        public int UserID { get; set; }
        public User User { get; set; }
    }
}
