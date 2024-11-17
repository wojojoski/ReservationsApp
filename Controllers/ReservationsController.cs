using Microsoft.AspNetCore.Mvc;
using ReservationsApp.Models;
using Microsoft.AspNetCore.Authorization;
using ReservationsApp.Services;
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
        public async Task<IActionResult> Index(string sortOrder, string searchString, string searchField)
        {
            ViewData["VoivodeshipSortParm"] = sortOrder == "Voivodeship" ? "voivodeship_desc" : "Voivodeship";
            ViewData["CitySortParm"] = sortOrder == "City" ? "city_desc" : "City";
            ViewData["DateAndTimeSortParm"] = sortOrder == "DateAndTime" ? "dateAndTime_desc" : "DateAndTime";
            ViewData["AvailableTimeSortParm"] = sortOrder == "AvailableTime" ? "availableTime_desc" : "AvailableTime";
            ViewData["NumberOfSeatsSortParm"] = sortOrder == "NumberOfSeats" ? "numberOfSeats_desc" : "NumberOfSeats";
            ViewData["PricePerHourSortParm"] = sortOrder == "PricePerHour" ? "pricePerHour_desc" : "PricePerHour";

            ViewData["CurrentFilter"] = searchString;
            ViewData["CurrentField"] = searchField;

            var reservations = _reservationservice.FindAllReservations();

            if (!string.IsNullOrEmpty(searchString) && !string.IsNullOrEmpty(searchField))
            {
                reservations = searchField switch
                {
                    "Voivodeship" => reservations.Where(r => r.Voivodeship.Contains(searchString, StringComparison.OrdinalIgnoreCase)).ToList(),
                    "City" => reservations.Where(r => r.City.Contains(searchString, StringComparison.OrdinalIgnoreCase)).ToList(),
                    "StreetAndNumber" => reservations.Where(r => r.StreetAndNumber.Contains(searchString, StringComparison.OrdinalIgnoreCase)).ToList(),
                    "DateAndTime" => reservations.Where(r => r.DateAndTime.ToString().Contains(searchString, StringComparison.OrdinalIgnoreCase)).ToList(),
                    "AvailableTime" => reservations.Where(r => r.AvailableTime.ToString().Contains(searchString, StringComparison.OrdinalIgnoreCase)).ToList(),
                    "NumberOfSeats" => reservations.Where(r => r.NumberOfSeats.ToString().Contains(searchString, StringComparison.OrdinalIgnoreCase)).ToList(),
                    "PricePerHour" => reservations.Where(r => r.PricePerHour.ToString().Contains(searchString, StringComparison.OrdinalIgnoreCase)).ToList(),
                    "UserEmail" => reservations.Where(r => r.UserEmail.Contains(searchString, StringComparison.OrdinalIgnoreCase)).ToList(),
                    _ => reservations
                };
            }

            switch (sortOrder)
            {
                case "Voivodeship":
                    reservations = reservations.OrderBy(r => r.Voivodeship).ToList();
                    break;
                case "voivodeship_desc":
                    reservations = reservations.OrderByDescending(r => r.Voivodeship).ToList();
                    break;
                case "City":
                    reservations = reservations.OrderBy(r => r.City).ToList();
                    break;
                case "city_desc":
                    reservations = reservations.OrderByDescending(r => r.City).ToList();
                    break;
                case "DateAndTime":
                    reservations = reservations.OrderBy(r => r.DateAndTime).ToList();
                    break;
                case "dateAndTime_desc":
                    reservations = reservations.OrderByDescending(r => r.DateAndTime).ToList();
                    break;
                case "AvailableTime":
                    reservations = reservations.OrderBy(r => r.AvailableTime).ToList();
                    break;
                case "availableTime_desc":
                    reservations = reservations.OrderByDescending(r => r.AvailableTime).ToList();
                    break;
                case "NumberOfSeats":
                    reservations = reservations.OrderBy(r => r.NumberOfSeats).ToList();
                    break;
                case "numberOfSeats_desc":
                    reservations = reservations.OrderByDescending(r => r.NumberOfSeats).ToList();
                    break;
                case "PricePerHour":
                    reservations = reservations.OrderBy(r => r.PricePerHour).ToList();
                    break;
                case "pricePerHour_desc":
                    reservations = reservations.OrderByDescending(r => r.PricePerHour).ToList();
                    break;
                default:
                    break;
            }

            return View(reservations);
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
            if(reservation == null  || reservation.IsBooked)
            {
                return NotFound();
            }
            reservation.IsBooked = true;
            reservation.BookedByUserId = user.Id;
            _reservationservice.UpdateBookedReservation(reservation);
            return RedirectToAction("UserReservations");
        }

        [HttpGet]
        public async Task<IActionResult> EditOffer(int id)
        {
            var reservation = await _reservationservice.FindReservationByIdAsync(id);
            if (reservation == null)
            {
                return NotFound();
            }
            return View(reservation);
        }

        [HttpPost]
        public IActionResult EditOffer(Reservation reservation)
        {
            if(ModelState.IsValid)
            {
                _reservationservice.UpdateOfferByOwner(reservation);
                return RedirectToAction(nameof(UserOffers));
            }
            return View(reservation);
        }

        [HttpGet]
        public async Task<IActionResult> DeleteOffer(int id)
        {
            var reservation = await _reservationservice.FindReservationByIdAsync(id);
            if(reservation == null )
            {
                return NotFound();
            }
            else if(reservation.IsBooked)
            {
                return ViewBag.ErrorMessage = "You cannot delete an offer that was booked by another user";
            }
            return View(reservation);
        }

        [HttpPost]
        public IActionResult DeleteOffer(Reservation reservation)
        {
                _reservationservice.DeleteOffer(reservation.ReservationId);
                return RedirectToAction(nameof(UserOffers));
        }
    }
}
