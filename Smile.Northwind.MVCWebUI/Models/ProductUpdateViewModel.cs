using System.Collections.Generic;
using Smile.Northwind.Entities.Concrete;

namespace Smile.Northwind.MvcWebUI.Models
{
    public class ProductUpdateViewModel
    {
        public Product Product { get; internal set; }
        public List<Category> Categories { get; internal set; }
    }
}