﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
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

        public IActionResult Index(int page = 1,int category=0)
        {
            int pageSize = 10;
            var products = productService.GetByCategory(category);
            ProductViewModel model = new ProductViewModel()
            {
                Products = products.Skip((page - 1) * pageSize).Take(pageSize).ToList(),
                PageCount = (int)Math.Ceiling(products.Count / (double)pageSize),
                PageSize = pageSize,
                CurrentCategoryID = category,
                CurrentPage=page,
            };
            return View(model);
        }

      

        //public string Session()
        //{
        //    HttpContext.Session.SetString("city", "izmir");
        //    HttpContext.Session.SetInt32("age", 21);
        //
        //    HttpContext.Session.GetString("city");
        //    HttpContext.Session.GetInt32("age");
        //}
    }
}
