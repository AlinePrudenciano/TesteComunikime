using ComunikimeTest.Domain.Entities;
using ComunikimeTest.Domain.Repositories;
using ComunikimeTest.Infra.Context;

namespace ComunikimeTest.Infra.Repositories
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        public UserRepository(ContextDb context) : base(context)
        {
        }
    }
}
