using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using Smile.Northwind.Business.Abstract;
using Smile.Northwind.MvcWebUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Smile.Northwind.MvcWebUI.ViewComponents
{
    public class CategoryViewComponent:ViewComponent
    {
        private ICategoryService categoryService;
        public CategoryViewComponent(ICategoryService categoryService)
        {
            this.categoryService = categoryService;
        }
        public ViewViewComponentResult Invoke()
        {
            CategoryViewModel model = new CategoryViewModel()
            {
                Categories = categoryService.GetAll(),
                CurrentCategory = Convert.ToInt32(HttpContext.Request.Query["category"])
                
            };
            return View(model);
        }
    }
}
