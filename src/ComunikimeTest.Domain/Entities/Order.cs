using System.Collections.Generic;

namespace ComunikimeTest.Domain.Entities
{
    public class Order : BaseEntity
    {
        public Order() : base()
        {

        }

        public int UserId { get; set; }
        public User User { get; set; }

        public List<OrderItem> Items { get; set; }

        public decimal Value { get; set; }
    }
}
