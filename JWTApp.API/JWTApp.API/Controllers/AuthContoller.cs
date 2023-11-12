using Microsoft.AspNetCore.Mvc;

namespace JWTApp.API.Controllers
{
    public class AuthContoller : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
