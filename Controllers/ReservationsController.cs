using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography.X509Certificates;
using ReservationsApp.Models;
using Microsoft.AspNetCore.Authorization;
using ReservationsApp.Services;
using System.Security.Claims;

namespace ReservationsApp.Controllers
{
    [Authorize(Roles = "user,admin")]
    public class ReservationsController : Controller
    {
        private readonly IReservationService _reservationservice;
        public ReservationsController(IReservationService reservationservice)
        {
            _reservationservice = reservationservice;
        }
        [AllowAnonymous]
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
        public IActionResult AddReservation(Reservation model)
        {
            if (ModelState.IsValid)
            {
            _reservationservice.AddReservation(model);
            return RedirectToAction("Index");
            }
            else
            {
                return View(model);
            }
        }
        //[HttpPost]
        //public IActionResult EditReservation(Reservation model)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        _reservationservice.UpdateReservation(model);
        //        return RedirectToAction(nameof(Index));
        //    }
        //    return View(model);
        //}
    }
}
