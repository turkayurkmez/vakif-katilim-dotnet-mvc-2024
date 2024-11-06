using eshop.Application.DataTransferObjects.Responses;
using eshop.Domain;

namespace eshop.MVC.Models
{
    public class ProductsIndexViewModel
    {
        public IEnumerable<ProductDisplayResponse> Products { get; set; }
        public PagingInfo PagingInfo { get; set; }
        public int? CategoryId { get; set; }
    }
}
