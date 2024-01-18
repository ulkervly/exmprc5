using Microsoft.AspNetCore.Mvc;

namespace Oxer.MVC.Areas.manage.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
