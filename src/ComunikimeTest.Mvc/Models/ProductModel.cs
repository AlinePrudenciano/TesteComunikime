using System;

namespace ComunikimeTest.Mvc.Models
{
    public class ProductModel : BaseModel
    {
        public ProductModel() : base()
        {

        }

        public string BarCode { get; set; }
        public string Name { get; set; }
        public decimal Value { get; set; }
        public bool Available { get; set; }
        public DateTime Validity { get; set; }
    }
}
