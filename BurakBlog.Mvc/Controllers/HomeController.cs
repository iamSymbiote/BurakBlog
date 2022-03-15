using Microsoft.AspNetCore.Mvc;

namespace BurakBlog.Mvc.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
