using eshop.Application.DataTransferObjects.Requests;
using eshop.Application.DataTransferObjects.Responses;
using eshop.Domain;
using eshop.Infrastructure;
using Mapster;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eshop.Application
{
    public class CustomProductService(IProductRepository repository) : IProductService
    {
        
        public async Task<int> CreateNewProduct(CreateNewProductRequest request)
        {
            var product = request.Adapt<Product>();
            await repository.Create(product);
            return product.Id;
        }

        public Product GetProductById(int id)
        {
          return repository.Get(id);
        }

        public IEnumerable<ProductDisplayResponse> GetProducts()
        {
            return repository.GetAll().Adapt<IEnumerable<ProductDisplayResponse>>();
        }

        public IEnumerable<ProductDisplayResponse> GetProductsByCategory(int categoryId)
        {
            return repository.GetProductsByCategory(categoryId).Adapt<IEnumerable<ProductDisplayResponse>>();
        }

        public IEnumerable<ProductDisplayResponse> SearchByName(string name)
        {
            return repository.Search(name).Adapt<IEnumerable<ProductDisplayResponse>>();
        }

        public async Task Update(UpdateExistingProductRequest request)
        {
           await repository.Update(request.Adapt<Product>());
        }
    }
}
