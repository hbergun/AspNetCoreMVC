using Microsoft.EntityFrameworkCore;
using Smile.Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Smile.Northwind.DataAccess
{
    public class NorthwindContext:DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

    }
}
