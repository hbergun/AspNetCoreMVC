using Smile.Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Smile.Northwind.MvcWebUI.Models
{
    public class ProductInsertViewModel
    {
        public Product Product { get; set; }
        public List<Category> Categories { get; set; }
    }
}
