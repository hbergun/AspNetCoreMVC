using Smile.Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Smile.Northwind.Business.Abstract
{
    public interface ICartService
    {
        void AddToCart(Cart cart,Product product);
        void RemoveFromCart(Cart cart,int productID);
        List<CartLine> CartLines(Cart cart);
    }
}
