using Microsoft.AspNetCore.Mvc;
using ReservationsApp.Interfaces;
using System.Security.Cryptography.X509Certificates;
using ReservationsApp.Models;

namespace ReservationsApp.Controllers
{
    public class ReservationsController : Controller
    {
        private readonly IReservationService _reservationservice;
        public ReservationsController(IReservationService reservationservice)
        {
            _reservationservice = reservationservice;
        }        
        public IActionResult Index()
        {
            return View(_reservationservice.FindAllReservations());
        }
        [HttpGet]
        public IActionResult AddReservation()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddReservation(Reservations model)
        {
            if(ModelState.IsValid)
            {
            _reservationservice.AddReservation(model);
            return RedirectToAction("Index");
            }
            else
            {
                return View(model);
            }

        }
    }
}
