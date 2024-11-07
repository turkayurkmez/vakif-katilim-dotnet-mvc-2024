using eshop.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eshop.Application
{
    public class UserService : IUserService
    {
        List<User> _users = new()
        {
             new(){ Id=1, UserName="turkay", Password="123456", Name="Türkay Ürkmez", Role="Admin"},
             new(){ Id=2, UserName="Abd", Password="123456", Name="Abdurrahman Karataş", Role="Editor"},
             new(){ Id=3, UserName="sgt", Password="123456", Name="Sena Tunçbilek", Role="Client"},

        };
        public User? ValidateUser(string username, string password)
        {
            return _users.SingleOrDefault(u=>u.UserName == username && u.Password == password);
        }
    }
}
