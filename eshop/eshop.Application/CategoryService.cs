using eshop.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eshop.Application
{
    public class CategoryService : ICategoryService
    {
        private List<Category> categories = new()
        {
             new(){ Id=1, Name="Kategori A"},
             new(){ Id=2, Name="Kategori B"},

        };
        public IEnumerable<Category> GetCategories()
        {
            return categories;
        }
    }
}
