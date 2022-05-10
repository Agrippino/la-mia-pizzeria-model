using Microsoft.AspNetCore.Mvc;

namespace PizzeriaAgrippino.Controllers
{
    public class Post : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
