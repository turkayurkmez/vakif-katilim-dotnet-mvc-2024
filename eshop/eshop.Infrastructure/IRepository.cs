using eshop.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eshop.Infrastructure
{
    public interface IRepository<T> where T : class, IEntity
    {
        IEnumerable<T> GetAll();
        T Get(int id);

        Task Create(T entity);
        Task Update(T entity);
        Task Delete(int id);

        Task<bool> IsExists(int id);
    }
}
