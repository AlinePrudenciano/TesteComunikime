using System;

namespace ComunikimeTest.Domain.Entities
{
    public class Product : BaseEntity
    {
        public Product() : base()
        {

        }

        public string Name { get; set; }
        public decimal Value { get; set; }
    }
}
