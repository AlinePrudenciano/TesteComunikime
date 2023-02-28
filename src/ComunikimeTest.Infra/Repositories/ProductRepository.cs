using ComunikimeTest.Domain.Entities;
using ComunikimeTest.Domain.Repositories;
using ComunikimeTest.Infra.Context;

namespace ComunikimeTest.Infra.Repositories
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        public ProductRepository(ContextDb context) : base(context)
        {
        }

    }
}
