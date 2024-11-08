using eshop.API.Models;
using eshop.Application;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace eshop.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ProductsController(IProductService productService) : ControllerBase
    {
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult Get()
        {
            var products = productService.GetProducts();
            return Ok(products);
        }

        [HttpGet("{id:int}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult Get(int id)
        {
            var product = productService.GetProductById(id);

            return product == null ? NotFound(new { info = $"{id} id'li ürün bulunamadı" })
                                   : Ok(product);
        }


        [HttpGet("{name}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult Search(string name) 
        { 
            var products = productService.SearchByName(name);
            var info = new ProductsResponseInfo
            {
                Products = products,
                Message = $"{(products.Count() == 0 ? "Aradığınız isimde bir ürün bulunamadı" : $"{products.Count()} adet ürün bulundu")}"
            };


            //return Ok(new
            //{
            //    Products = products,
            //    Message = $"{(products.Count() == 0 ? "Aradığınız isimde bir ürün bulunamadı" : $"{products.Count()} adet ürün bulundu")}",
            //    ResponseTime = DateTime.Now
            //});

            return Ok(info);
        }



    }
}
