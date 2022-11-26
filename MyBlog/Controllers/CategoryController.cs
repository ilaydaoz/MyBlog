﻿using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace MyBlog.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategoryService _categoryService; // Class içindeki private değişkenler alt tireli tanımlanır Zorunda mısın hayır ama bir standart...
        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }
        public IActionResult Index()
        {
            var values = _categoryService.GetList();
            return View(values);
        }
    }
}