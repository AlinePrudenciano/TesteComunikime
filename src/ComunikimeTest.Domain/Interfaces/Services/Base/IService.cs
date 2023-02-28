using ComunikimeTest.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace ComunikimeTest.Domain.Interfaces.Services
{
    public interface IService<T> where T : BaseEntity
    {
        Task<List<T>> Get(CancellationToken cancellationToken);
        Task<T> Get(int id, CancellationToken cancellationToken);
        Task Delete(int id, CancellationToken cancellationToken);
        Task Add(T obj, CancellationToken cancellationToken);
        Task Update(T obj, int id, CancellationToken cancellationToken);
    }
}
