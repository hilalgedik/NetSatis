using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using NetSatis.Entities.Context;
using NetSatis.Entities.InterFaces;

namespace NetSatis.Entities
{
    public interface IEntityRepository<TContex,TEntity> 
        where TContex:DbContext,new()
        where TEntity : class,IEntity, new()

    {
         void AddOrUpdate(TContex context, TEntity entity);
         void Delete(TContex context, Expression<Func<TEntity, bool>> filter);
         void Save(TContex context);

    }
}
