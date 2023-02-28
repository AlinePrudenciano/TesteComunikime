using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComunikimeTest.Domain.Entities
{
    public class Stock : BaseEntity
    {
        public Stock() : base()
        {

        }

        public int ProductId { get; set; }
        public Product Product { get; set; }

        public int Amount { get; set; }
    }
}
