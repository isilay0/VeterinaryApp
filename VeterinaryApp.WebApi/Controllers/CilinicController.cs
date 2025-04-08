using Microsoft.AspNetCore.Mvc;

namespace VeterinaryApp.WebApi.Controllers
{
    public class CilinicController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
