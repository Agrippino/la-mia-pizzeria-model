using Microsoft.AspNetCore.Mvc;
using PizzeriaAgrippino.Models;
using PizzeriaAgrippino.Utilies;

namespace PizzeriaAgrippino.Controllers
{
    public class PizzaController : Controller
    {
        public IActionResult Index()
        {
            List<Pizze> pizzes = PostData.GetPosts();
            return View("CorpoPagina",pizzes);
        }
    }
}
 