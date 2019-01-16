using Smile.Northwind.Entities.Concrete;
using System.Collections.Generic;

namespace Smile.Northwind.Business.Abstract
{
    public interface ICategoryService
    {
        List<Category> GetAll();
    }
}
