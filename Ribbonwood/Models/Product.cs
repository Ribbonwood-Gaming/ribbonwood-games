using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ribbonwood.Models
{

    public class Product
    {
        public int ID { get; set; }
        public float Price { get; set; }
        public int Quanitiy { get; set; }

        public int VendorID { get; set; }
        public Vendor Vendor { get; set; }

    }
}
