using System;

namespace ComunikimeTest.Front.Models
{
    public class ProductModel : BaseModel
    {
        public ProductModel() : base()
        {

        }

        public string Name { get; set; }
        public decimal Value { get; set; }
    }
}
