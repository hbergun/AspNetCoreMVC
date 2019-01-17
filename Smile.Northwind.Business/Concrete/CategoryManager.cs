using Smile.Northwind.Business.Abstract;
using Smile.Northwind.DataAccess.Abstract;
using Smile.Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Smile.Northwind.Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        //Doğrudan Diğer Katmana Erişmek Doğru Değildir.Bu Yüzden Interfaceler Üzerinden Haberleşilmelidir.
        private ICategoryDAL categoryDAL;
        public CategoryManager(ICategoryDAL categoryDAL)
        {
            this.categoryDAL = categoryDAL;
        }
        
        public List<Category> GetAll()
        {
            return categoryDAL.GetList();
        }
    }
}
