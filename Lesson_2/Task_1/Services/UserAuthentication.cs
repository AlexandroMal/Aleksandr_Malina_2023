using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Task_1.Data;
using Task_1.Services.Interfaces;

namespace Task_1.Services
{
    class UserAuthentication : IUserAuthentication
    {
        private Users _users = new Users();
        public bool CheckUserName(string name)
        {
            foreach (var user in _users.users)
            {
                if (user.Name == name)
                {
                    return true;
                }
            }

            return false;
        }

        public bool CheckPassword(string password) 
        {
            foreach (var user in _users.users)
            {
                if (user.Password == password)
                {
                    return true;
                }
            }

            return false;
        }

        public bool CheckUser(string name, string password)
        {
            foreach (var user in _users.users)
            {
                if (user.Name == name && user.Password == password)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
