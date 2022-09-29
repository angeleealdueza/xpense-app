using Microsoft.AspNetCore.Mvc;

namespace Xpense_App.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {


            return View();
        }
    }
}
