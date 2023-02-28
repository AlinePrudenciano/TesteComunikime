using System;
using System.Collections.Generic;

namespace ComunikimeTest.Domain.Entities
{
    public class User : BaseEntity
    {
        public User() : base()
        {
        }

        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        public bool IsAdmin { get; set; }

        public List<Order> Orders { get; set; }
    }
}
