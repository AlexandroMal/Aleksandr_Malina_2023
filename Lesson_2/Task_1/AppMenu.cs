using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_1.Services;
using Task_1.Services.Interfaces;

namespace Task_1
{
    class AppMenu
    {
        public IUserAuthentication userAuthentication;
        public IUserLogin loginUser;
        public IUserRegister registerUser;

        public AppMenu()
        {
            userAuthentication = new UserAuthentication();
            loginUser = new UserLogin();
            registerUser = new UserRegister();
        }

        public void AppStart()
        {
            while (true)
            {
                int operation = MenuOperation();

                switch (operation)
                {
                    case 1:
                        RegistrationUser();
                        break;
                    case 2:
                        LoginUser();
                        break;
                    case 3:
                        return;
                    default:
                        Console.WriteLine("Enter the correct number!");
                        break;
                }
            }
        }

        public int MenuOperation()
        {
            Console.WriteLine("Welcome. Choice what you wanna do.\n" +
               "Press 1 to Registration\n" +
               "Press 2 to Login in app\n" +
               "Press 3 to exit the app\n");

            var operation = InputNumbers();

            return operation;
        }

        public void RegistrationUser()
        {
            Console.WriteLine("Enter login:");
            var name = InputString();
            Console.WriteLine("Enter password:");
            var password = InputString();

            if (userAuthentication.CheckUserName(name) == true)
            {
                Console.WriteLine("A user with the same name already exists! Try again!");
            }
            else
            {
                registerUser.RegisterUser(name, password);
                Console.WriteLine("Registration was successful!");
            }
        }

        public void LoginUser()
        {
            Console.WriteLine("Enter login:");
            var name = InputString();
            Console.WriteLine("Enter password:");
            var password = InputString();

            if (userAuthentication.CheckUser(name, password) == true)
            {
                loginUser.LoginUser(name, password);
            }
            else
            {
                Console.WriteLine("Error login. Wrong password or login!");
            }
        }

        private string InputString()
        {
            return Console.ReadLine();
        }

        private int InputNumbers()
        {
            try
            {
                var number = Convert.ToInt32(Console.ReadLine());
                return number;
            }
            catch
            {
                Console.WriteLine("Enter the number, not string!");
                return 0;
            }

        }
    }
}
