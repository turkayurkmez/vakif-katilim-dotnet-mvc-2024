using eshop.Application.DataTransferObjects.Responses;

namespace eshop.API.Models
{
    public class ProductsResponseInfo
    {
        public IEnumerable<ProductDisplayResponse> Products { get; set; }
        public int Count { get => Products.Count(); }

        public string Message { get; set; }
    }
}
