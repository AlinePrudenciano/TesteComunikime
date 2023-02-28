using System.Collections.Generic;

namespace ComunikimeTest.Front.Models
{
    public class OrderModel : BaseModel
    {
        public OrderModel() : base()
        {
            Items = new List<OrderItemModel>();
        }

        public int UserId { get; set; }
        public UserModel User { get; set; }

        public List<OrderItemModel> Items { get; set; }

        public decimal Value { get; set; }
    }
}
