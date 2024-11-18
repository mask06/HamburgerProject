using Hamburger.DAL.Context;
using Hamburger.DAL.Entities.Abstract;
using Hamburger.DAL.Exceptions;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Hamburger.DAL.Repositories.Abstract
{
    public abstract class Repository<TEntity> : IRepository<TEntity>,IDisposable where TEntity : BaseEntity
    {
        private protected HamburgerDbContext _dbContext;
        private protected DbSet<TEntity> _entities;
        private bool disposed = false;

        protected Repository(HamburgerDbContext dbContext)
        {
            _dbContext = dbContext;
            _entities = _dbContext.Set<TEntity>();
        }

        public void Add(TEntity entity)
        {
            _entities.Add(entity);
        }

        public int Update(TEntity entity)
        {
                entity.Updated = DateTime.Now;

            _entities.Update(entity);

            return entity.ID;
        }
        public int Delete(TEntity entity)
        {
            entity.Deleted = DateTime.Now;
            return Update(entity);
        }
        public int Delete(int id)
        {
            TEntity? entity = _entities.Where(s => s.ID == id).ToList().SingleOrDefault();

            if (entity is not null)
            {
                entity.Deleted = DateTime.Now;
                return Update(entity);
            }
            throw new EntityNotFound($"No record with Id:{id} found in the {_entities.GetType().Name} table.");
        }
        public void Remove(TEntity entity)
        {
            _entities.Remove(entity);
        }
        public void Remove(int id)
        {
            TEntity? entity = _entities.Where(s => s.ID == id).ToList().SingleOrDefault();

            if (entity is not null)
                _entities.Remove(entity);

            throw new EntityNotFound($"No record with Id:{id} found in the {_entities.GetType().Name} table.");
        }
        public TEntity? Get(int id)
        {
            TEntity? entity = _entities.AsNoTracking().Where(e => e.ID == id).FirstOrDefault();

            if (entity is not null)
                return entity;
            return null;
        }

        public ICollection<TEntity> GetAll()
        {
            return _entities.ToList();
        }
        public ICollection<TEntity> GetAll(Expression<Func<TEntity, bool>> predicate)
        {
            return _entities.Where(predicate).ToList();
        }
        // Kullanılan kaynakları serbest bırakır.
        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _dbContext.Dispose();
                }
            }
            this.disposed = true;
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
