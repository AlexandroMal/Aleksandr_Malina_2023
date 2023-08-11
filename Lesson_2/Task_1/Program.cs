using Task_1;
using Task_1.Services;

UserService userService = new UserService();
userService.RegisterUser("Sasha", "12345");
userService.LoginUser("Sasha", "12345");
userService.RemoveUser("Sasha", "12345");
userService.LoginUser("Sasha", "12345");

AppMenu menu = new AppMenu();
menu.AppStart();
