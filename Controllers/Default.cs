using Microsoft.AspNetCore.Mvc;

namespace mvcP.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
