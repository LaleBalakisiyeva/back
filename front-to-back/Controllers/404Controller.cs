using Microsoft.AspNetCore.Mvc;

namespace front_to_back.Controllers
{
    public class _404Controller : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
