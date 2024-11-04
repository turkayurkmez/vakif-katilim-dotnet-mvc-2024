using introduceMVCandCore.Models;
using Microsoft.AspNetCore.Mvc;

namespace introduceMVCandCore.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Name = "Türkay";
            ViewBag.Hour = DateTime.Now.Hour;

            var people = new List<Person> { 
                new() { Id=1, Name="Sabriye", Address="Çanakkale"},
                new() { Id=2, Name="Türkay", Address="Eskişehir"},
                new() { Id=3, Name="Emrah", Address="İstanbul"}
            };

            //ViewBag.People = people;


            return View(people);
        }
    }
}
