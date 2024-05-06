using Microsoft.AspNetCore.Mvc;

namespace FirstTask.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
