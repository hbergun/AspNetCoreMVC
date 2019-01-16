using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Smile.Northwind.Business.Abstract;

namespace Smile.Northwind.MVCWebUI.Controllers
{
    public class ProductController : Controller
    {
        IProductService productService;
        public ProductController(IProductService productService)
        {
            this.productService = productService;
        }

        public IActionResult Index()
        {
            return View();
        }


    }
}