using Core.BaseEntity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories.Abstract
{
    public interface IEntityRepository<TEntity>
        where TEntity : class, IBaseEntity, new()

    {
   
        IQueryable<TEntity> Table { get; }
        IQueryable<TEntity> AsNoTracking { get; }

        List<TEntity> GetAll(Expression<Func<TEntity, bool>>? filter = null);
        TEntity Get(Expression<Func<TEntity, bool>> filter);
        void Add(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);
    }
}
