using AutoMapper;
using ComunikimeTest.Api.Models;
using ComunikimeTest.Domain.Entities;
using ComunikimeTest.Domain.Interfaces.Services;
using ComunikimeTest.Domain.Services;
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
    public class StockController : BaseController<Stock, StockModel>
    {
        private readonly IMapper _mapper;
        private readonly IStockService _stockService;

        public StockController(IMapper mapper, IStockService service) : base(mapper, service)
        {
            _mapper = mapper;
            _stockService = service;
        }


        [HttpPost("{userId}")]
        public async Task<IActionResult> Create([FromBody] StockModel stock, int userId, CancellationToken cancellationToken)
        {
            try
            {
                await _stockService.Add(_mapper.Map<Stock>(stock), userId, cancellationToken);
                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.InnerException?.Message ?? ex.Message);
            }
        }

        [HttpPut("{userId}")]
        public async Task<IActionResult> Buy([FromBody] StockModel stock, int userId, CancellationToken cancellationToken)
        {
            try
            {
                await _stockService.Add(_mapper.Map<Stock>(stock), userId, cancellationToken);
                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.InnerException?.Message ?? ex.Message);
            }
        }
    }
}
