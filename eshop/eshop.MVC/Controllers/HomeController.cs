using eshop.Application;
using eshop.Domain;
using eshop.MVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace eshop.MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IProductService productService;

        public HomeController(ILogger<HomeController> logger, IProductService productService)
        {
            _logger = logger;
            this.productService = productService;
        }


        public IActionResult Index(int pageNo = 1)
        {
            //db'den çek, sayfada göster!
            //ProductService productService = new ProductService();

            var products = productService.GetProducts();
            var totalItem = products.Count;
            var itemPerPage = 8;

            var totalPages = (int)Math.Ceiling((decimal)totalItem / itemPerPage);
            var pagingInfo = new PagingInfo
            {
                ItemsPerPage = itemPerPage,
                TotalItems = totalItem,
                CurrentPage = pageNo
            };
            //ViewBag.Pages = totalPages;
            //ViewBag.CurrentPage = pageNo;
            /*
             * 1. 
             * 0...8
             * 2.
             * 8..16
             * 3.
             * 16. 
             */
            var start = (pageNo - 1) * itemPerPage;
            var end = start + itemPerPage;
            var paginated = products.Take(start..end);
            var model = new ProductsIndexViewModel { PagingInfo =pagingInfo, Products = paginated};

            return View(model);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
