using AutoMapper;
using ComunikimeTest.Domain.Entities;
using ComunikimeTest.Domain.Interfaces.Services;
using ComunikimeTest.Front.Models;

namespace ComunikimeTest.Front.Controllers
{
    public class UserController : BaseController<User, UserModel>
    {
        public UserController(IUserService service, IMapper mapper) : base(service, mapper)
        {
        }
    }
}
