using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Smile.Northwind.Business.Abstract;
using Smile.Northwind.MvcWebUI.Models;

namespace Smile.Northwind.MvcWebUI.Controllers
{
    public class ProductController : Controller
    {
        private IProductService productService;
        public ProductController(IProductService productService)
        {
            this.productService = productService;
        }

        public IActionResult Index()
        {
            var products = productService.GetAll();
            ProductViewModel model = new ProductViewModel() { Products=products };
            return View(model);
        }
    }
}