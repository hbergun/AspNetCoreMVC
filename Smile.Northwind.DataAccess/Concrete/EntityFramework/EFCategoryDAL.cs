using Smile.Northwind.Entities.Concrete;
using Smile.Core.DataAccess.EntityFramework;
using Smile.Northwind.DataAccess.Abstract;

namespace Smile.Northwind.DataAccess.Concrete.EntityFramework
{
    public class EFCategoryDAL : EFRepositoryBase<Category, NorthwindContext>, ICategoryDAL
    {
    }
}
