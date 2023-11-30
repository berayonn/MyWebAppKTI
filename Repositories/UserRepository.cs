using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyWebApp.Models;

namespace MyWebApp.Repositories
{
    public class UserRepository : IUserRepository
    {
        private List<UserModel> users = new List<UserModel>{
            new UserModel{Id=7113,Name="Bryan",Password="123123",
            FavoriteColor="purple",Role="admin",GoogleId="12345678"}
        };
        public UserModel? GetByGoogleId(string googleId)
        {
            throw new NotImplementedException();
        }

        public UserModel? GetByUsernameAndPassword(string username, string password)
        {
            var user = users.SingleOrDefault(u=>u.Name == username && password=="123123");
            return user;
        }
    }
}