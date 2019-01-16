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
        public List<Product> GetAll()
        {

        }

        public List<Product> GetByCategory(int categoryID)
        {
            throw new NotImplementedException();
        }
    }
}
