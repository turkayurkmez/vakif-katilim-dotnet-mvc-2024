using eshop.Domain;

namespace eshop.Application
{
    public interface IProductService
    {
        List<Product> GetProducts();
        List<Product> GetProductsByCategory(int categoryId);

        Product GetProductById(int id);
    }
}