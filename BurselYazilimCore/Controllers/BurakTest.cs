using Microsoft.AspNetCore.Mvc;

namespace BurselYazilimCore.Controllers
{
    public class BurakTest : Controller
    {
        // GET
        public IActionResult Index()
        {
            return View();
        }

        public ActionResult Deneme()
        {
            return View();
        }

        public ActionResult Saas()
        {
            ViewBag.Title = "Anasayfa";
            
            return View();
        }
    }
}