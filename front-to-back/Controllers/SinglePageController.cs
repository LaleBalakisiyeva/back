using front_to_back.Models;
using front_to_back.ViewModels;
using Microsoft.AspNetCore.Mvc;
namespace front_to_back.Controllers
{
    public class SinglePageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
