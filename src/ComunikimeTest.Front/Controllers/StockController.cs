using AutoMapper;
using ComunikimeTest.Domain.Entities;
using ComunikimeTest.Domain.Interfaces.Services;
using ComunikimeTest.Front.Models;

namespace ComunikimeTest.Front.Controllers
{
    public class StockController : BaseController<Stock, StockModel>
    {
        public StockController(IStockService service, IMapper mapper) : base(service, mapper)
        {
        }
    }
}
