using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography.X509Certificates;
using ReservationsApp.Models;
using Microsoft.AspNetCore.Authorization;
using ReservationsApp.Services;
using System.Security.Claims;
using Microsoft.AspNetCore.Identity;

namespace ReservationsApp.Controllers
{
    [Authorize(Roles = "user,admin")]
    public class ReservationsController : Controller
    {
        private readonly IReservationService _reservationservice;
        private readonly UserManager<IdentityUser> _userManager;
        public ReservationsController(IReservationService reservationservice, UserManager<IdentityUser> userManager)
        {
            _reservationservice = reservationservice;
            _userManager = userManager;
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
                model.IsBooked = false;
                _reservationservice.AddReservation(model);
                return RedirectToAction("Index");
            }
            else
            {
                return View(model);
            }
        }
        [HttpGet]
        public async Task<IActionResult> UserOffers()
        {
            var user = await _userManager.GetUserAsync(User);
            if(user == null)
            {
                return Unauthorized();
            }
            var reservations = await _reservationservice.FindReservationsByUserEmailAsync(user.Email);

            return View(reservations);
        }
        [HttpGet]
        public async Task<IActionResult> UserReservations()
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return Unauthorized();
            }
            var reservations = await _reservationservice.FindBookedReservationsByUserIdAsync(user.Id);
            return View(reservations);
        }
        [HttpPost]
        public async Task<IActionResult> BookNow(int id)
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return Unauthorized();
            }

            var reservation = await _reservationservice.FindReservationByIdAsync(id);
            //var reservation = _reservationservice.FindReservationById(id);
            if(reservation == null  || reservation.IsBooked)
            {
                return NotFound();
            }
            reservation.IsBooked = true;
            reservation.BookedByUserId = user.Id;
            _reservationservice.UpdateBookedReservation(reservation);
            return RedirectToAction("UserReservations");
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
