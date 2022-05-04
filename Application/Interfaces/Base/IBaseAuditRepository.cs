using Domain.Base.Entity;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Application.Interfaces.Repositories.Base
{
    public interface IBaseAuditRepository<T, TContext>
        where T : AuditBaseEntity
        where TContext : DbContext
    {
        public IQueryable<T> Entities { get; }

        public void Delete(T entity);

        public Task<T> GetByIdAsync(long id);

        public Task<List<T>> GetListAsync();

        public Task<T> AddAsync(T entity);

        public int SaveChanges();

        public Task<int> SaveChangesAsync();

        public void Update(T entity);
    }

    public interface IBaseIdentityRepository<T, TContext>
    where T : IdentityBaseEntity
    where TContext : DbContext
    {
        public IQueryable<T> Entities { get; }

        public void Delete(T entity);

        public Task<T> GetByIdAsync(long id);

        public Task<List<T>> GetListAsync();

        public Task<T> AddAsync(T entity);

        public int SaveChanges();

        public Task<int> SaveChangesAsync();

        public void Update(T entity);
    }
}