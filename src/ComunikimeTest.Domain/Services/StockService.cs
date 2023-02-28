using ComunikimeTest.Domain.Entities;
using ComunikimeTest.Domain.Interfaces.Services;
using ComunikimeTest.Domain.Repositories;
using System.Threading.Tasks;
using System.Threading;
using System;

namespace ComunikimeTest.Domain.Services
{
    public class StockService : Service<Stock>, IStockService
    {
        private readonly IUserRepository _userRepository;
        private readonly new IStockRepository _repository;

        public StockService(IStockRepository repository,
                            IUserRepository userRepository) : base(repository)
        {
            _userRepository = userRepository;
            _repository = repository;
        }

        public async Task Add(Stock stock, int userId, CancellationToken cancellationToken)
        {
            var user = await _userRepository.Get(userId, cancellationToken);

            if (user == null || !user.IsAdmin)
                throw new Exception("Invalid user.");

            var dbStock = await _repository.GetByProduct(stock.ProductId, cancellationToken);

            if(dbStock == null)
                await _repository.Add(stock, cancellationToken);
            else
                dbStock.Amount = stock.Amount;

        }
    }
}
