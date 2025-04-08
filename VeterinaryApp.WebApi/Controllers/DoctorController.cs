using Microsoft.AspNetCore.Mvc;

namespace VeterinaryApp.WebApi.Controllers
{
    public class DoctorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
