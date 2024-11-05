using eshop.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eshop.Application
{
    public class ProductService : IProductService
    {
        List<Product> products = new List<Product>()
            {
                new(){ Id=1, Name="Ürün A", Description="Ürün A'nın açıklaması", Price=1m, StockCount=100, CategoryId=1},
                new(){ Id=2, Name="Ürün B", Description="Ürün B'nın açıklaması", Price=1m, StockCount=100,CategoryId=1},
                new(){ Id=3, Name="Ürün C", Description="Ürün C'nın açıklaması", Price=1m, StockCount=100,CategoryId=1},
                new(){ Id=4, Name="Ürün D", Description="Ürün D'nın açıklaması", Price=1m, StockCount=100,CategoryId=1},
                new(){ Id=5, Name="Ürün E", Description="Ürün E'nın açıklaması", Price=1m, StockCount=100, CategoryId = 2},
                new(){ Id=6, Name="Ürün F", Description="Ürün A1'nın açıklaması", Price=1m, StockCount=100, CategoryId = 2},
                new(){ Id=7, Name="Ürün G", Description="Ürün B2'nın açıklaması", Price=1m, StockCount=100, CategoryId = 1},
                new(){ Id=8, Name="Ürün H", Description="Ürün C3'nın açıklaması", Price=1m, StockCount=100, CategoryId = 2},
                new(){ Id=9, Name="Ürün I", Description="Ürün D4'nın açıklaması", Price=1m, StockCount=100, CategoryId = 2},
                new(){ Id=10, Name="Ürün İ", Description="Ürün E5'nın açıklaması", Price=1m, StockCount=100, CategoryId = 2},
                  new(){ Id=11, Name="Ürün A3", Description="Ürün A'nın açıklaması", Price=1m, StockCount=100, CategoryId=1},
                new(){ Id=12, Name="Ürün B3", Description="Ürün B'nın açıklaması", Price=1m, StockCount=100,CategoryId=1},
                new(){ Id=13, Name="Ürün C3", Description="Ürün C'nın açıklaması", Price=1m, StockCount=100,CategoryId=1},
                new(){ Id=14, Name="Ürün D3", Description="Ürün D'nın açıklaması", Price=1m, StockCount=100,CategoryId=1},
                new(){ Id=15, Name="Ürün E3", Description="Ürün E'nın açıklaması", Price=1m, StockCount=100, CategoryId = 2},
                new(){ Id=16, Name="Ürün F3", Description="Ürün A1'nın açıklaması", Price=1m, StockCount=100, CategoryId = 2},
                new(){ Id=17, Name="Ürün G3", Description="Ürün B2'nın açıklaması", Price=1m, StockCount=100, CategoryId = 1},
                new(){ Id=18, Name="Ürün H3", Description="Ürün C3'nın açıklaması", Price=1m, StockCount=100, CategoryId = 2},
                new(){ Id=19, Name="Ürün I3", Description="Ürün D4'nın açıklaması", Price=1m, StockCount=100, CategoryId = 2},
                new(){ Id=20, Name="Ürün İ3", Description="Ürün E5'nın açıklaması", Price=1m, StockCount=100, CategoryId = 2},
            };
        public List<Product> GetProducts()
        {

            return products;
        }

        public List<Product> GetProductsByCategory(int categoryId) => products.Where(p=>p.CategoryId==categoryId).ToList();
    }
}
