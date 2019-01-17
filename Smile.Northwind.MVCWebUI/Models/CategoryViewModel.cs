using Smile.Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Smile.Northwind.MvcWebUI.Models
{
    public class CategoryViewModel
    {
        public List<Category> Categories { get; internal set; }
    }
}
