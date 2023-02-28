using System;

namespace ComunikimeTest.Api.Models
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
