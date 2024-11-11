using Microsoft.AspNetCore.Mvc;

namespace ReservationsApp.Controllers
{
    public class YourOffers : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
