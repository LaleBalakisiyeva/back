using Microsoft.AspNetCore.Mvc;

namespace front_to_back.Controllers
{
    public class ShopController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
