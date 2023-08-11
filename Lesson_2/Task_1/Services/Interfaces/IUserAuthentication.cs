using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1.Services.Interfaces
{
    interface IUserAuthentication
    {
        public bool CheckUserName(string name);
        public bool CheckPassword(string password);
        public bool CheckUser(string name, string password);
    }
}
