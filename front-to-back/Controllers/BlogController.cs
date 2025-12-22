using Microsoft.AspNetCore.Mvc;

namespace front_to_back.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
