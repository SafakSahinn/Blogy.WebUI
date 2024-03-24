using Blogy.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Blogy.WebUI.Controllers
{
    public class CategoryController1 : Controller
    {
        private readonly ICategoryService _categoryService;

        public CategoryController1(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public IActionResult CategoryList()
        {
            var values = _categoryService.TGetListAll();
            return View(values);
        }
    }
}
