using AutoMapper;
using ComunikimeTest.Domain.Entities;
using ComunikimeTest.Domain.Interfaces.Services;
using ComunikimeTest.Mvc.Models;

namespace ComunikimeTest.Mvc.Controllers
{
    public class ProductController : BaseController<Product, ProductModel>
    {
        public ProductController(IProductService service, IMapper mapper) : base(service, mapper)
        {
        }
    }
}
