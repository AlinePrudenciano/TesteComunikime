using ComunikimeTest.Domain.Entities;
using ComunikimeTest.Domain.Interfaces.Services;
using ComunikimeTest.Domain.Repositories;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace ComunikimeTest.Domain.Services
{
    public class ProductService : Service<Product>, IProductService
    {
        private readonly IUserRepository _userRepository;

        public ProductService(IProductRepository repository,
                              IUserRepository userRepository) : base(repository)
        {
            _userRepository = userRepository;
        }

        public async Task Add(Product product, int userId, CancellationToken cancellationToken)
        {
            var user = await _userRepository.Get(userId, cancellationToken);

            if (user == null || !user.IsAdmin)
                throw new Exception("Invalid user.");

            await _repository.Add(product, cancellationToken);

        }
    }
}
