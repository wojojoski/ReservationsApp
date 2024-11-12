using Microsoft.AspNetCore.Mvc;

namespace ReservationsApp.Controllers
{
    public class BookReservationsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
