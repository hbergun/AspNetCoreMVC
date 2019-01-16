using Smile.Core.DataAccess;
using Smile.Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Smile.Northwind.DataAccess.Abstract
{
    public interface IProductDAL:IEntityRepository<Product>
    {
        //Custom Operations For Product
    }
}
