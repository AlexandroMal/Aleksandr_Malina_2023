using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1.Services.Interfaces
{
    interface IUserLogin
    {
        public void LoginUser(string name, string password);
    }
}
