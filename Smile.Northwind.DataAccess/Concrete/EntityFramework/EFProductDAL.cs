using Smile.Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using Smile.Core.DataAccess.EntityFramework;
using Smile.Northwind.DataAccess.Abstract;

namespace Smile.Northwind.DataAccess.Concrete.EntityFramework
{
    public class EFProductDAL:EFRepositoryBase<Product,NorthwindContext>,IProductDAL
    {
    }
}
