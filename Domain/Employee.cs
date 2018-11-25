using System;
using System.Collections.Generic;

namespace Domains
{
    public partial class Employee : BaseEntity
    {
        public Employee()
        {
            Orders = new HashSet<Order>();
        }

        public string Email { get; set; }
        public string Password { get; set; }
        public string FullName { get; set; }
        public string City { get; set; }
        public DateTime? RegistrationDate { get; set; }
        public string Phone { get; set; }

        public ICollection<Order> Orders { get; set; }
    }
}
