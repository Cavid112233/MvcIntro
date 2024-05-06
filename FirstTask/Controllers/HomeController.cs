using Microsoft.AspNetCore.Mvc;

namespace FirstTask.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
