using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using System.Net.Sockets;
using System.Security.Claims;
using WebAuthentication.Data;
using WebAuthentication.Models;

namespace WebAuthentication.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Verify()
        {
            Users users = new Users();

            var username = Request.Form["username"];
            var password = Request.Form["password"];

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                TempData["ErrorMessage"] = $"You did not enter username or password.";
                return RedirectToAction("Index");
            }

            var user = users.UserValidation(username, password);

            if (user != null)
            {
                return RedirectToAction("AdminStatus", "Home", user);
            }
            else
            {
                TempData["ErrorMessage"] = "You entered the wrong password or username.";
                return RedirectToAction("Index");
            }
        }
    
    }
}
