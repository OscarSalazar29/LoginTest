using Microsoft.AspNetCore.Mvc;

namespace PC2_Views.Controllers
{
    public class SecurityController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Validate(string username, string password)
        {
            if (username == "OscarSalazar" && password == "12345")
            {
                return RedirectToAction("Index", "Customer",new { area = "Sales" });
            }
            else{
                return RedirectToAction("Login");
            }
        }

    }
}
