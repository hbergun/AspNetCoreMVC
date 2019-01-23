using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using Smile.Northwind.MvcWebUI.Models;
using Smile.Northwind.MvcWebUI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Smile.Northwind.MvcWebUI.ViewComponents
{
    public class CartSummaryViewComponent : ViewComponent
    {
        private ICartSessionService _cartSessionService;
        public CartSummaryViewComponent(ICartSessionService cartSessionService)
        {
            _cartSessionService = cartSessionService;
        }

        public ViewViewComponentResult Invoke()
        {
            var model = new CartSummaryViewModel()
            {
                Cart = _cartSessionService.GetCart()
            };

            return View(model);
        }

    }
}
