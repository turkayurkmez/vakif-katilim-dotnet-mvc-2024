using eshop.Application;
using eshop.MVC.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace eshop.MVC.Controllers
{
    public class BasketController(IProductService productService) : Controller
    {
        public IActionResult Index()
        {
            var shoppingCard = getShoppingCardFromSession();
            return View(shoppingCard);
        }

        public IActionResult AddToCart(int id)
        {
            var product = productService.GetProductById(id);
            if (product is null)
            {
                return Json(new { message = $"{id} id'li ürün bulunamadı!" });
            }

            ShoppingCard? shoppingCard = getShoppingCardFromSession();

            shoppingCard!.Add(new BasketItem { Product = product, Quantity = 1 });
            saveToSession(shoppingCard);

            return Json(new { message=$"{id} değeri sunucuya ulaştı" });
        }

        private void saveToSession(ShoppingCard shoppingCard)
        {
           HttpContext.Session.SetString("basket",JsonConvert.SerializeObject(shoppingCard));
        }

        private ShoppingCard? getShoppingCardFromSession()
        {
           var serializedJson =  HttpContext.Session.GetString("basket");
            if (serializedJson is not null)
            {
                //JSON serialization işleminde private field'ler dönüştürülemez.
                return JsonConvert.DeserializeObject<ShoppingCard>(serializedJson);
            }
            return new ShoppingCard();

        }
    }
}
