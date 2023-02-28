using AutoMapper;
using ComunikimeTest.Api.Models;
using ComunikimeTest.Domain.Entities;
using ComunikimeTest.Domain.Interfaces.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System.Threading;
using System;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ComunikimeTest.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderItemController : BaseController<OrderItem, OrderItemModel>
    {
        public OrderItemController(IMapper mapper, IOrderItemService service) : base(mapper, service)
        {
        }
    }
}
