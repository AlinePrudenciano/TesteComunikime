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
    public class ProductController : BaseController<Product, ProductModel>
    {
        private readonly IProductService _productService;
        private readonly IMapper _mapper;

        public ProductController(IMapper mapper, IProductService service) : base(mapper, service)
        {
            _productService = service;
            _mapper = mapper;
        }


        [HttpPost("{userId}")]
        public async Task<IActionResult> Create([FromBody] ProductModel product, int userId, CancellationToken cancellationToken)
        {
            try
            {
                await _productService.Add(_mapper.Map<Product>(product), userId, cancellationToken);
                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.InnerException?.Message ?? ex.Message);
            }
        }
    }
}
