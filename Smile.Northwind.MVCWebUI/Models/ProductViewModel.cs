using Smile.Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Smile.Northwind.MvcWebUI.Models
{
    public class ProductViewModel
    {
        public List<Product> Products { get;internal set; }
        public int PageCount { get; set; }
        public int PageSize { get; set; }
        public int CurrentCategoryID { get; set; }
        public int CurrentPage { get; set; }
    }
}
