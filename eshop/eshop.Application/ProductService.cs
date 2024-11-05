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
                new(){ Id=1, Name="Ürün A", Description="Ürün A'nın açıklaması", Price=1m, StockCount=100},
                new(){ Id=2, Name="Ürün B", Description="Ürün B'nın açıklaması", Price=1m, StockCount=100},
                new(){ Id=3, Name="Ürün C", Description="Ürün C'nın açıklaması", Price=1m, StockCount=100},
                new(){ Id=4, Name="Ürün D", Description="Ürün D'nın açıklaması", Price=1m, StockCount=100},
                new(){ Id=5, Name="Ürün E", Description="Ürün E'nın açıklaması", Price=1m, StockCount=100},
                new(){ Id=6, Name="Ürün F", Description="Ürün A1'nın açıklaması", Price=1m, StockCount=100},
                new(){ Id=7, Name="Ürün G", Description="Ürün B2'nın açıklaması", Price=1m, StockCount=100},
                new(){ Id=8, Name="Ürün H", Description="Ürün C3'nın açıklaması", Price=1m, StockCount=100},
                new(){ Id=9, Name="Ürün I", Description="Ürün D4'nın açıklaması", Price=1m, StockCount=100},
                new(){ Id=10, Name="Ürün İ", Description="Ürün E5'nın açıklaması", Price=1m, StockCount=100},
            };
        public List<Product> GetProducts()
        {

            return products;
        }
    }
}
