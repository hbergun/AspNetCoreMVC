using Smile.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Smile.Core.DataAccess
{
    public interface IEntityRepository<T> where T:class, IEntity,new() 
        //Bu Generic Type Class tipinde Olmalı Ve IEntity Implemente Etmeli.
        //Çünkü Gelen Tipin Bir Veri Tabanı Tablosunun Entity'si Olduğunu Bilmeliyiz.
    {
        T Get(Expression<Func<T,bool>> filter=null);
        List<T> GetList(Expression<Func<T, bool>> filter = null);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
