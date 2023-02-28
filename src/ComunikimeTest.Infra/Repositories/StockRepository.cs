using ComunikimeTest.Domain.Entities;
using ComunikimeTest.Domain.Repositories;
using ComunikimeTest.Infra.Context;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace ComunikimeTest.Infra.Repositories
{
    public class StockRepository : Repository<Stock>, IStockRepository
    {
        public StockRepository(ContextDb context) : base(context)
        {
        }

        public async Task<Stock> GetByProduct(int productId, CancellationToken cancellationToken)
        {
            return await _context.Stocks.FirstOrDefaultAsync(s => s.ProductId == productId, cancellationToken);
        }
    }
}
