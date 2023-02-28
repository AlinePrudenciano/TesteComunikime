using System.Collections.Generic;

namespace ComunikimeTest.Front.Models
{
    public class OrderItemModel : BaseModel
    {
        public OrderItemModel() : base()
        {

        }

        public ProductModel Product { get; set; }
        public int Amount { get; set; }
    }
}
