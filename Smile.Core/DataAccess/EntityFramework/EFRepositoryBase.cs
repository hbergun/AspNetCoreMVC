using Microsoft.EntityFrameworkCore;
using Smile.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Smile.Core.DataAccess.EntityFramework
{
    public class EFEntityRepositoryBase<TEntity, TContext> : IEntityRepository<TEntity>
        where TEntity : class, IEntity, new()
        where TContext : DbContext, new()
    {
        public TEntity Get(Expression<Func<TEntity, bool>> filter = null)
        {
            using (var context=new TContext())
            {
                return context.Set<TEntity>().SingleOrDefault(filter);
                //Single OR Defualt Type Rew
                //Gelen Concrate Class'ın Tipi Yani DbTablosu için Set<TEntity>()
            }
        }

        public List<TEntity> GetList(Expression<Func<TEntity, bool>> filter = null)
        {
            using (var context = new TContext())
            {
                return filter == null ? context.Set<TEntity>().ToList() : context.Set<TEntity>().Where(filter).ToList();
                //Gelen Concrate Class'ın Tipi Yani DbTablosu için Set<TEntity>()
            }
        }

        public void Add(TEntity entity)
        {
            using (var context=new TContext())
            {
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(TEntity entity)
        {
            using (var context = new TContext())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

      
        public void Update(TEntity entity)
        {
            using (var context = new TContext())
            {
                var modifiedEntity = context.Entry(entity);
                modifiedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
