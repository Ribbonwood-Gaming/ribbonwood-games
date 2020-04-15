using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ribbonwood.Models
{
    public class User
    {
        public int ID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }

        public IEnumerable<Order> Orders { get; set; }
    }
}
