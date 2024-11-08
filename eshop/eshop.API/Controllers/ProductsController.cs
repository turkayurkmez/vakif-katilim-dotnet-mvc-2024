using eshop.API.Models;
using eshop.Application;
using eshop.Application.DataTransferObjects.Requests;
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


        [HttpGet("[action]/{name}")]
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
        //https://localhost:8080/Products
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> Create(CreateNewProductRequest request)
        {
            if (ModelState.IsValid)
            {
                var productId = await productService.CreateNewProduct(request);
                return CreatedAtAction(nameof(Get), routeValues: new { id = productId }, value: null);
            }

            return BadRequest(ModelState);
        }

        [HttpPut("{id:int}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> Update(int id, UpdateExistingProductRequest request)
        {
            if (await productService.IsProductExists(id))
            {
                if (ModelState.IsValid)
                {
                    await productService.Update(request);
                    return NoContent();
                }
            }
            else
            {
                ModelState.AddModelError("info", $"{id} id'li ürün bulunamadı");
            }

            return BadRequest(ModelState);

        }


        [HttpDelete("{id:int}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> Delete(int id)
        {
            if (await productService.IsProductExists(id))
            {


                await productService.Delete(id);
                return Ok(new { message = $"{id} id'li ürün başarıyla silindi" });

            }
            else
            {
                ModelState.AddModelError("info", $"{id} id'li ürün bulunamadı");
            }

            return BadRequest(ModelState);

        }


    }
}
