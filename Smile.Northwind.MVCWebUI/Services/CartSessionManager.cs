using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Smile.Northwind.Entities.Concrete;
using Smile.Northwind.MvcWebUI.ExtensionMethods;

namespace Smile.Northwind.MvcWebUI.Services
{
    public class CartSessionManager : ICartSessionService
    {
        private IHttpContextAccessor httpContextAccessor;
        public CartSessionManager(IHttpContextAccessor httpContextAccessor)
        {
            this.httpContextAccessor = httpContextAccessor;
        }

        public Cart GetCart()
        {
            Cart CartCheck = httpContextAccessor.HttpContext.Session.GetObject<Cart>("cart");
            if (CartCheck==null)
            {
                httpContextAccessor.HttpContext.Session.SetObject("cart", new Cart());
                CartCheck= httpContextAccessor.HttpContext.Session.GetObject<Cart>("cart");
            }
            return CartCheck;
        }

        public void SetCart(Cart cart)  
        {
            httpContextAccessor.HttpContext.Session.SetObject("cart",new Cart());

        }
    }
}
