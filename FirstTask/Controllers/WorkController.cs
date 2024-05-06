using Microsoft.AspNetCore.Mvc;

namespace FirstTask.Controllers
{
    public class WorkController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult WorkSingle()
        {
            return View();
        }
    }
}
