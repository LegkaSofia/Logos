using Library.Core.Models;
using System.Collections.Generic;
using System.Linq;

namespace Library.Core.Services
{
    public class UserService
    {
        private List<User> users;

        public UserService()
        {
            users = new List<User>
            {
                new User {Name = "Taras", Login = "admin", Password = "admin", Roles = new List<string> {"admin"}},
                new User {Name = "Petro", Login = "petro", Password = "petro", Roles = new List<string> {"user"}}
            };
        }

        public List<User> GetAll()
        {
            return users;
        }

        public void AddUser(User user)
        {
            users.Add(user);
        }

        public User GetByLoginAndPassword(string login, string password)
        {
            return users.FirstOrDefault(u => u.Login == login && u.Password == password);
        }
    }
}
