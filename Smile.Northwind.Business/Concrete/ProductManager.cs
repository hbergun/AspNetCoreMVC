using Smile.Northwind.Business.Abstract;
using Smile.Northwind.DataAccess.Abstract;
using Smile.Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Smile.Northwind.Business.Concrete
{
    public class ProductManager : IProductService
    {
        private IProductDAL productDAL;
        public ProductManager(IProductDAL productDAL)
        {
            this.productDAL = productDAL;
        }

        public void Add(Product product)
        {
            productDAL.Add(product);
        }

        public void Update(Product product)
        {
            productDAL.Update(product);
        }

        public void Delete(int productID)
        {
            productDAL.Delete(new Product { ProductID=productID });
        }

        public List<Product> GetAll()
        {
            return productDAL.GetList();
        }

        public List<Product> GetByCategory(int categoryID)
        {
            return productDAL.GetList(p => p.CategoryID == categoryID || categoryID== 0);
        }

      
    }
}
