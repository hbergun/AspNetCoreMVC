using Smile.Core.DataAccess;
using Smile.Northwind.Entities.Concrete;

namespace Smile.Northwind.DataAccess.Abstract
{
    public interface ICategoryDAL : IEntityRepository<Category>
    {
        //Custom Operations For Category
    }
}
