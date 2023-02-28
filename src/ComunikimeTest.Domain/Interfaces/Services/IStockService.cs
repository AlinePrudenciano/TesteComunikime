using ComunikimeTest.Domain.Entities;
using System.Threading;
using System.Threading.Tasks;

namespace ComunikimeTest.Domain.Interfaces.Services
{
    public interface IStockService : IService<Stock>
    {
        Task Add(Stock stock, int userId, CancellationToken cancellationToken);
    }
}
