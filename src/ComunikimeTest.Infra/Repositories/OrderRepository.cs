using ComunikimeTest.Domain.Entities;
using ComunikimeTest.Domain.Repositories;
using ComunikimeTest.Infra.Context;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Threading;
using System.Linq;

namespace ComunikimeTest.Infra.Repositories
{
    public class OrderRepository : Repository<Order>, IOrderRepository
    {
        public OrderRepository(ContextDb context) : base(context)
        {
        }


        public async new Task<List<Order>> Get(CancellationToken cancellationToken)
        {
            return await _context.Orders
                                 .AsNoTracking()
                                 .Include("User")
                                 .Include("Items")
                                 .Include("Items.Product")
                                 .ToListAsync(cancellationToken);
        }

        public async new Task<Order> Get(int id, CancellationToken cancellationToken)
        {
            return await _context.Orders
                                 .AsNoTracking()
                                 .Where(x => x.Id == id)
                                 .Include("User")
                                 .Include("Items")
                                 .Include("Items.Product")
                                 .FirstOrDefaultAsync(cancellationToken);
        }


    }
}
