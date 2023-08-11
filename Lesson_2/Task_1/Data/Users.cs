using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_1.Entity;

namespace Task_1.Data
{
    public class Users
    {
        public List<User> users = new List<User>();

        public Users() {
            users.Add(new User("Sasha", "Password"));
        }

        public void AddUsers(string name, string password)
        {
            users.Add(new User(name, password));
        }
    }
}
