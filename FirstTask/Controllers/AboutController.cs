using Microsoft.AspNetCore.Mvc;

namespace FirstTask.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
