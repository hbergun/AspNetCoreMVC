using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Smile.Northwind.Business.Abstract;
using Smile.Northwind.Entities.Concrete;
using Smile.Northwind.MvcWebUI.Models;

namespace Smile.Northwind.MvcWebUI.Controllers
{
    public class AdminController : Controller
    {
        private IProductService _productService;
        private ICategoryService _categoryService;
        public AdminController(IProductService productService, ICategoryService categoryService)
        {
            _productService = productService;
            _categoryService = categoryService;
        }
        public IActionResult Index()
        {
            var model = new ProductViewModel()
            {
                Products = _productService.GetAll()
            };
            return View(model);
        }

        [HttpGet]
        public IActionResult Insert()
        {

            ProductInsertViewModel model = new ProductInsertViewModel()
            {
                Categories = _categoryService.GetAll()
            };
            return View(model);
        }

        [HttpPost]
        public IActionResult Insert(Product product)
        {
            if (ModelState.IsValid)
            {
                _productService.Add(product);
                TempData.Add("message", "Product was Succesfully added");
            }

            return RedirectToAction("Insert");
        }

        public IActionResult Update(int ProductID)
        {
            ProductUpdateViewModel model = new ProductUpdateViewModel()
            {
                Product = _productService.GetByID(ProductID),
                Categories = _categoryService.GetAll()
            };
            return View(model);
        }

        [HttpPost]
        public IActionResult Update(Product product)
        {
            if (ModelState.IsValid)
            {
                _productService.Update(product);
                TempData.Add("message", "Product was Succesfully updated");
            }

            return RedirectToAction("Update");
        }

        public IActionResult Delete(int ProductID)
        {
            _productService.Delete(ProductID);
            TempData.Add("message", "Product was Succesfully deleted");

            return RedirectToAction("Index");
        }
    }
}