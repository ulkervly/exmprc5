using Microsoft.AspNetCore.Mvc;

namespace Oxer.MVC.Areas.manage.Controllers
{
    [Area("manage")]
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
