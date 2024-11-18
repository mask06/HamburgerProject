using Hamburger.DAL.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Hamburger.DAL.Repositories.Abstract
{
    public interface IRepository<TEntity>:IDisposable where TEntity : BaseEntity
    {
        void Add(TEntity entity);
        int Update(TEntity entity);
        int Delete(TEntity entity);
        int Delete(int id);
        void Remove(TEntity entity);
        void Remove(int id);

        TEntity? Get(int id);
        ICollection<TEntity> GetAll();
        ICollection<TEntity> GetAll(Expression<Func<TEntity, bool>> predicate);
    }
}
