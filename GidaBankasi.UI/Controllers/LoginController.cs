
using GidaBankasi.DataLayer.Managers;
using Microsoft.AspNetCore.Mvc;
using WebCore.Extensions;

namespace GidaBankasi.UI.Controllers
{
    
    public class LoginController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(string user, string password)
        {
            var userManager = new UserManager();
            var emailAndPassword = userManager.GetUserByEmailAndPassword(user, password);
            if (emailAndPassword != null)
            {
                HttpContext.Session.SetObjectAsJson("login_type", emailAndPassword.LoginType);
            }
            
            return View(emailAndPassword);
        }
        
    }
}