using eshop.Application;
using eshop.Application.DataTransferObjects.Requests;
using Mapster;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace eshop.MVC.Controllers
{
    [Authorize(Roles = "Admin,Editor")]
    public class ProductsController(IProductService productService, ICategoryService categoryService) : Controller
    {
        public IActionResult Index()
        {
            var products = productService.GetProducts();
            return View(products);
        }

        public IActionResult Create()
        {
            ViewBag.Categories = getCategories();
            return View();
        }

        private IEnumerable<SelectListItem> getCategories()
        {
            var categories = categoryService.GetCategories();
            return categories.Select(c => new SelectListItem { Text = c.Name, Value = c.Id.ToString() });
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateNewProductRequest request)
        {
            if (ModelState.IsValid)
            {
              var id = await productService.CreateNewProduct(request);
                return RedirectToAction(nameof(Index));

            }
            ViewBag.Categories = getCategories();
            return View();

        }

        public IActionResult Edit(int id)
        {
            ViewBag.Categories = getCategories();
            var product = productService.GetProductById(id);
            var updateRequest = product.Adapt<UpdateExistingProductRequest>();
            return View(updateRequest);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(UpdateExistingProductRequest request)
        {
            if (ModelState.IsValid)
            {
               await productService.Update(request);
                return RedirectToAction(nameof(Index));
            }
            ViewBag.Categories = getCategories();
            return View(request);

        }
    }
}
