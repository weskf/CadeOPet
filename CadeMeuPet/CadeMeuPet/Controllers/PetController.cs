using Microsoft.AspNetCore.Mvc;

namespace CadeMeuPet.Controllers
{
    public class PetController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
