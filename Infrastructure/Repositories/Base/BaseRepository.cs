using Application.Interfaces.Repositories.Base;
using Domain.Base.Entity;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Infrastructure.Repositories.Base
{
    public class BaseIdentityRepository<T, TContext> : IBaseIdentityRepository<T, TContext>
        where T : IdentityBaseEntity
        where TContext : DbContext
    {
        private readonly TContext _dbContext;

        public BaseIdentityRepository(TContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IQueryable<T> Entities
        {
            get
            {
                return _dbContext.Set<T>();
            }
        }

        public void Delete(T entity)
        {
            _dbContext.Remove(entity);

            //await _distributedCache.RemoveAsync(_baseCacheKey.ListKey);

            //await _distributedCache.RemoveAsync(_baseCacheKey.GetKey(entity.Id));
        }

        public async Task<T> GetByIdAsync(long id)
        {
            return await Entities.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<List<T>> GetListAsync()
        {
            return await Entities.ToListAsync();
        }

        public async Task<T> AddAsync(T entity)
        {
            var model = await _dbContext.AddAsync(entity);

            return model.Entity;
        }

        public int SaveChanges()
        {
            return _dbContext.SaveChanges();
        }

        public async Task<int> SaveChangesAsync()
        {
            return await _dbContext.SaveChangesAsync();
        }

        public void Update(T entity)
        {
            _dbContext.Update(entity);

            //await _distributedCache.RemoveAsync(_baseCacheKey.ListKey);

            //await _distributedCache.RemoveAsync(_baseCacheKey.GetKey(entity.Id));
        }
    }

    public class BaseAuditRepository<T, TContext> : IBaseAuditRepository<T, TContext>
        where T : AuditBaseEntity
        where TContext : DbContext
    {
        private readonly TContext _dbContext;

        public BaseAuditRepository(TContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IQueryable<T> Entities
        {
            get
            {
                return _dbContext.Set<T>();
            }
        }

        public void Delete(T entity)
        {
            _dbContext.Remove(entity);

            //await _distributedCache.RemoveAsync(_baseCacheKey.ListKey);

            //await _distributedCache.RemoveAsync(_baseCacheKey.GetKey(entity.Id));
        }

        public async Task<T> GetByIdAsync(long id)
        {
            return await Entities.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<List<T>> GetListAsync()
        {
            return await Entities.ToListAsync();
        }

        public async Task<T> AddAsync(T entity)
        {
            var model = await _dbContext.AddAsync(entity);

            return model.Entity;
        }

        public int SaveChanges()
        {
            return _dbContext.SaveChanges();
        }

        public async Task<int> SaveChangesAsync()
        {
            return await _dbContext.SaveChangesAsync();
        }

        public void Update(T entity)
        {
            _dbContext.Update(entity);

            //await _distributedCache.RemoveAsync(_baseCacheKey.ListKey);

            //await _distributedCache.RemoveAsync(_baseCacheKey.GetKey(entity.Id));
        }
    }
}