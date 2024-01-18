using Microsoft.AspNetCore.Mvc;
using Oxer.MVC;


namespace Oxer.MVC.Controllers
{
    public class HomeController : Controller
    {
        
        public IActionResult Index()
        {
            return View();
        }


       
    }
}
