using Microsoft.AspNetCore.Mvc;

namespace VeterinaryApp.WebApi.Controllers
{
    public class BreedController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
