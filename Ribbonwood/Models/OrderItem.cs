using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ribbonwood.Models
{
    public class OrderItem
    {
        public int ID { get; set; }
        public ICollection<Product> Products { get; set; }
        public int OrderID { get; set; }
        public Order Order { get; set; }
        public int Quanitity { get; set; }
    }
}
