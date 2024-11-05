using eshop.Application;
using Microsoft.AspNetCore.Mvc;

namespace eshop.MVC.ViewComponents
{
    public class CategoryMenuViewComponent(ICategoryService categoryService) : ViewComponent
    {
        
        public IViewComponentResult Invoke()
        {
            var categories = categoryService.GetCategories();
            return View(categories);
        }
    }
}
