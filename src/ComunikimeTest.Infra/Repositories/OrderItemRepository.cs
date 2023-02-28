using ComunikimeTest.Domain.Entities;
using ComunikimeTest.Domain.Repositories;
using ComunikimeTest.Infra.Context;

namespace ComunikimeTest.Infra.Repositories
{
    public class OrderItemRepository : Repository<OrderItem>, IOrderItemRepository
    {
        public OrderItemRepository(ContextDb context) : base(context)
        {
        }

    }
}
