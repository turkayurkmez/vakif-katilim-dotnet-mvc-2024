using eshop.Domain;
using eshop.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eshop.Infrastructure
{
    public class ProductRepostiory(VakifEshopDbContext dbContext) : IProductRepository
    {

        public async Task Create(Product entity)
        {
            dbContext.Products.Add(entity);
            await dbContext.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var product = Get(id);
           
            dbContext.Products.Remove(product);
            await dbContext.SaveChangesAsync();
        }

        public Product? Get(int id)
        {
            return dbContext.Products.AsNoTracking().SingleOrDefault(p => p.Id == id);

        }

        public IEnumerable<Product> GetAll()
        {
            return dbContext.Products.AsNoTracking().Include(p => p.Category);
        }

        public IEnumerable<Product> GetProductsByCategory(int categoryId)
        {
            return dbContext.Products.AsNoTracking().Where(p => p.CategoryId == categoryId);
        }

        public async Task<bool> IsExists(int id)
        {
            return await dbContext.Products.AnyAsync(p => p.Id == id);
        }

        public IEnumerable<Product> Search(string name)
        {
           return dbContext.Products.AsNoTracking().Where(p=>p.Name.Contains(name));
        }

        public async Task Update(Product entity)
        {
            dbContext.Products.Update(entity);
            await dbContext.SaveChangesAsync();
        }
    }
}
