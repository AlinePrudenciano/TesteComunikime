using System.Collections.Generic;

namespace ComunikimeTest.Mvc.Models
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
