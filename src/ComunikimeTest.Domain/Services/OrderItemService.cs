using ComunikimeTest.Domain.Entities;
using ComunikimeTest.Domain.Interfaces.Services;
using ComunikimeTest.Domain.Repositories;

namespace ComunikimeTest.Domain.Services
{
    public class OrderItemService : Service<OrderItem>, IOrderItemService
    {
        public OrderItemService(IOrderItemRepository repository) : base(repository)
        {

        }
    }
}
