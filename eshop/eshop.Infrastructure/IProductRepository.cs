using eshop.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eshop.Infrastructure
{
    public interface IProductRepository : IRepository<Product>
    {
        IEnumerable<Product> Search(string name);
        IEnumerable<Product> GetProductsByCategory(int  categoryId);
    }
}
