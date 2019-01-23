using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Smile.Northwind.Business.Abstract;
using Smile.Northwind.Entities.Concrete;
using Smile.Northwind.MvcWebUI.Models;
using Smile.Northwind.MvcWebUI.Services;

namespace Smile.Northwind.MvcWebUI.Controllers
{
    public class CartController : Controller
    {
        private ICartSessionService _cartSessionService;
        private ICartService _cartService;
        private IProductService _productService;
        public CartController(ICartSessionService cartSessionService, ICartService cartService, IProductService productService)
        {
            _cartSessionService = cartSessionService;
            _cartService = cartService;
            _productService = productService;
        }

        public IActionResult AddToCart(int ProductID)
        {
            var productToBeAdded = _productService.GetByID(ProductID);
            var cart = _cartSessionService.GetCart(); //HttpContext.Session Kullanma!
            _cartService.AddToCart(cart, productToBeAdded);
            _cartSessionService.SetCart(cart);
            TempData.Add("message", String.Format("Your product {0}, was succesfully added to the cart!", productToBeAdded.ProductName));
            return RedirectToAction("Index", "Product");
        }

        public IActionResult List()
        {
            var cart = _cartSessionService.GetCart();
            CartSummaryViewModel model = new CartSummaryViewModel()
            {
                Cart = cart
            };
            return View(model);
        }

        public IActionResult Remove(int ProductID)
        {
            var cart = _cartSessionService.GetCart();
            _cartService.RemoveFromCart(cart, ProductID);
            _cartSessionService.SetCart(cart);
            TempData.Add("message", "Your product was succesfully removed to the cart!");
            return RedirectToAction("List");
        }
        
        public IActionResult Complete()
        {
            var model = new ShippingDetailsViewModel()
            {
                ShippingDetails = new ShippingDetails()
            };
            return View(model);
        }
    }
}