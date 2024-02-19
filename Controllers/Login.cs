using Microsoft.AspNetCore.Mvc;

namespace mvcP.Controllers
{
    public class Login : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult GirisYap() 
        {
            return View();  
        }
    }
}
