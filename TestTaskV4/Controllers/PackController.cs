using Microsoft.AspNetCore.Mvc;

namespace TestTaskV4.Controllers
{
    public class PackController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
