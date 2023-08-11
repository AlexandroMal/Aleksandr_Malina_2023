using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_1.Data;
using Task_1.Services.Interfaces;

namespace Task_1.Services
{
    class UserRegister : IUserRegister
    {
        private Users _users = new Users();
        public void RegisterUser(string name, string password)
        {
            _users.AddUsers(name, password);
        }
    }
}
