using Microsoft.AspNetCore.Mvc;

namespace KartverketGruppe5.Controllers
{
    public class BrukerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
