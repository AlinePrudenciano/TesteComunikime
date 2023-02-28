using ComunikimeTest.Domain.Entities;
using System.Threading.Tasks;
using System.Threading;

namespace ComunikimeTest.Domain.Repositories
{
    public interface IStockRepository : IRepository<Stock>
    {
        Task<Stock> GetByProduct(int productId, CancellationToken cancellationToken);
    }
}
