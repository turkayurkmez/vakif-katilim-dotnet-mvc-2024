using eshop.Domain;

namespace eshop.MVC.Models
{
    public class ProductsIndexViewModel
    {
        public IEnumerable<Product> Products { get; set; }
        public PagingInfo PagingInfo { get; set; }
        public int? CategoryId { get; set; }
    }
}
