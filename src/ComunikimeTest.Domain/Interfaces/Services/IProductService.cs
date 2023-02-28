using ComunikimeTest.Domain.Entities;
using System.Threading;
using System.Threading.Tasks;

namespace ComunikimeTest.Domain.Interfaces.Services
{
    public interface IProductService : IService<Product>
    {
        Task Add(Product product, int userId, CancellationToken cancellationToken);
    }
}
