using System;
using System.Text;

namespace Smile.Northwind.Entities.Concrete
{
    public class CartLine
    {
        public Product Product { get; set; }
        public int ProductQuantity { get; set; }
    }
}
