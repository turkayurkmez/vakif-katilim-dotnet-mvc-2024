using eshop.Domain;

namespace eshop.Application
{
    public interface IProductService
    {
        List<Product> GetProducts();
    }
}