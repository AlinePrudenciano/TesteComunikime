using AutoMapper;
using ComunikimeTest.Domain.Entities;
using ComunikimeTest.Domain.Interfaces.Services;
using ComunikimeTest.Mvc.Models;

namespace ComunikimeTest.Mvc.Controllers
{
    public class OrderItemController : BaseController<OrderItem, OrderItemModel>
    {
        public OrderItemController(IOrderItemService service, IMapper mapper) : base(service, mapper)
        {
        }
    }
}
