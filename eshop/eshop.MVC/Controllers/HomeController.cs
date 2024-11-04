using eshop.Domain;
using eshop.MVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace eshop.MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            //db'den çek, sayfada göster!
            var products = new List<Product>()
            {
                new(){ Id=1, Name="Ürün A", Description="Ürün A'nın açıklaması", Price=1m, StockCount=100},
                new(){ Id=2, Name="Ürün B", Description="Ürün B'nın açıklaması", Price=1m, StockCount=100},
                new(){ Id=3, Name="Ürün C", Description="Ürün C'nın açıklaması", Price=1m, StockCount=100},
                new(){ Id=4, Name="Ürün D", Description="Ürün D'nın açıklaması", Price=1m, StockCount=100},
                new(){ Id=5, Name="Ürün E", Description="Ürün E'nın açıklaması", Price=1m, StockCount=100},

            };
            return View(products);
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
