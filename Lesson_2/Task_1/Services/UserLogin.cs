using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_1.Data;
using Task_1.Services.Interfaces;

namespace Task_1.Services
{
    class UserLogin : IUserLogin
    {
        private Users _users = new Users();
        public void LoginUser(string name, string password)
        {
            Console.WriteLine("Login was successful!");
        }
    }
}
