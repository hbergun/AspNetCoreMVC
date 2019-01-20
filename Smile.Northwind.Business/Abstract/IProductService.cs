using Smile.Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Smile.Northwind.Business.Abstract
{
    public interface IProductService
    {
        List<Product> GetAll();
        List<Product> GetByCategory(int categoryID);
        void Add(Product product);
        void Update(Product product);
        void Delete(int productID);
        Product GetByID(int ProductID);

    }
}
