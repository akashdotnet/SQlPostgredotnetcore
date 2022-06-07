using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PostgreSQLDB.Models;

namespace PostgreSQLDB.Interface
{
    public interface IAsyncRepository<T> where T : EntityBase
    {
        Task<T> GetByIdAsync(long id);
        Task<IReadOnlyList<T>> ListAllAsync();
        Task<T> AddAsync(T entity);
        Task UpdateAsync(T entity);
        Task DeleteAsync(T entity);

    }
}
