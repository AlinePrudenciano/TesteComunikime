using AutoMapper;
using ComunikimeTest.Domain.Entities;
using ComunikimeTest.Domain.Interfaces.Services;
using ComunikimeTest.Mvc.Models;

namespace ComunikimeTest.Mvc.Controllers
{
    public class OrderController : BaseController<Order, OrderModel>
    {
        public OrderController(IOrderService service, IMapper mapper) : base(service, mapper)
        {
        }
    }
}
