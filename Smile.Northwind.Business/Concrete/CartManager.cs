using Smile.Northwind.Business.Abstract;
using Smile.Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Smile.Northwind.Business.Concrete
{
    public class CartManager : ICartService
    {
        public void AddToCart(Cart cart, Product product)
        {
            CartLine cartLine = cart.CartLines.FirstOrDefault(c => c.Product.ProductID == product.ProductID);
            if (cartLine != null)
            {
                cartLine.ProductQuantity++;
                return;
            }
            cart.CartLines.Add(new CartLine { Product = product, ProductQuantity = 1 });
        }

        public List<CartLine> CartLines(Cart cart)
        {
            return cart.CartLines;
        }

        public void RemoveFromCart(Cart cart, int productID)
        {
            cart.CartLines.Remove(cart.CartLines.FirstOrDefault(c => c.Product.ProductID == productID));
        }
    }
}
