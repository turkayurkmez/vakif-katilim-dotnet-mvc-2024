using eshop.Domain;
using eshop.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eshop.Application
{
    public class CustomCategoryService(ICategoryRepository categoryRepository) : ICategoryService
    {
        public IEnumerable<Category> GetCategories()
        {
            return categoryRepository.GetAll();
        }
    }
}
