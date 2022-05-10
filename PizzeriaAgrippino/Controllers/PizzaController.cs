using Microsoft.AspNetCore.Mvc;
using PizzeriaAgrippino.Models;
using PizzeriaAgrippino.Utilies;

namespace PizzeriaAgrippino.Controllers
{
    public class PizzaController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {   //il controller dice le liste e il modello 
            //quando chiamo il controller idez il controller si chiama la lista dei post con il metodo getspost()
            List<Pizze> pizzes = PostData.GetPosts();
            //poi dobbiamo passare una razor, quindi inseriamo il nome della lista, cioè pizzes 
            // potremmo anche non inserire homepage nel caso in cui avessimo lasciato il file nominato index 
            return View("HomePage",pizzes);
        }
    }
}
 