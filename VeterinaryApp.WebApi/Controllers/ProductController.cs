using Microsoft.AspNetCore.Mvc;

namespace VeterinaryApp.WebApi.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
