using eshop.Application.DataTransferObjects.Requests;
using eshop.Application.DataTransferObjects.Responses;
using eshop.Domain;

namespace eshop.Application
{
    public interface IProductService
    {
        IEnumerable<ProductDisplayResponse> GetProducts();
        IEnumerable<ProductDisplayResponse> GetProductsByCategory(int categoryId);

        Product GetProductById(int id);

        Task<int> CreateNewProduct(CreateNewProductRequest request);
        Task Update(UpdateExistingProductRequest request);
        
        IEnumerable<ProductDisplayResponse> SearchByName(string name);
        Task<bool> IsProductExists(int id);
        Task Delete(int id);
      
    }
}