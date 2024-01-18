using Microsoft.AspNetCore.Mvc;

namespace Oxer.MVC.Areas.manage.Controllers
{
    public class DashBoardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
