using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Agenda.Domain.Contracts.Repositories
{
    public interface IBaseRepository<TEntity> : IDisposable where TEntity : class
    {
        Task Add(TEntity entity);
        Task AddList(List<TEntity> entity);
        Task<TEntity> GetById(Guid id);
        Task<List<TEntity>> GetAll();
        Task Update(TEntity entity);
        Task Remove(TEntity entity);
        Task RemoveAll(List<TEntity> entities);
    }
}
