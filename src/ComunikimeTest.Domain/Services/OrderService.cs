using ComunikimeTest.Domain.Entities;
using ComunikimeTest.Domain.Interfaces.Services;
using ComunikimeTest.Domain.Repositories;
using System.Threading;
using System;
using System.Threading.Tasks;
using System.Linq;

namespace ComunikimeTest.Domain.Services
{
    public class OrderService : Service<Order>, IOrderService
    {
        private readonly IStockRepository _stockRepository;

        public OrderService(IOrderRepository repository,
                            IStockRepository stockRepository) : base(repository)
        {
            _stockRepository = stockRepository;
        }

        public async new Task Add(Order order, CancellationToken cancellationToken)
        {
            foreach (var item in order.Items)
            {
                var stock = await _stockRepository.GetByProduct(item.ProductId, cancellationToken);

                if (stock.Amount < item.Amount)
                    throw new Exception("There are not enough items to complete the order.");
            }                

            foreach(var item in order.Items)
            {
                var stock = await _stockRepository.GetByProduct(item.ProductId, cancellationToken);

                stock.Amount -= item.Amount;

                await _stockRepository.Update(stock, cancellationToken);
            }
            
            await _repository.Add(order, cancellationToken);
        }
    }
}
