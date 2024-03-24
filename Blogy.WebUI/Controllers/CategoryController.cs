﻿using Blogy.BusinessLayer.Abstract;
using Blogy.EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Blogy.WebUI.Controllers
{
	public class CategoryController : Controller
	{
		private readonly ICategoryService _categoryService;

		public CategoryController(ICategoryService categoryService)
		{
			_categoryService = categoryService;
		}

		public IActionResult CategoryList()
		{
			var values = _categoryService.TGetListAll();
			return View(values);
		}

		[HttpGet]
		public IActionResult CreateCategory()
		{
			return View();
		}

		[HttpPost]
		public IActionResult CreateCategory(Category category)
		{
			_categoryService.TInsert(category);
			return RedirectToAction("CategoryList");
		}
	}
}
