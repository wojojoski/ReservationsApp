using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ReservationsApp.Models
{
    public class Reservation
    {
        [Key]
        public int ReservationId { get; set; }
        [Required(ErrorMessage = "Enter Voivodeship")]
        [DisplayName("Voivodeship")]
        public string Voivodeship { get; set; }
        [Required(ErrorMessage = "Enter City")]
        [DisplayName("City")]
        public string City { get; set; }
        [Required(ErrorMessage = "Enter Street and Number")]
        [DisplayName("Street and Number")]
        public string StreetAndNumber { get; set; }
        [Required(ErrorMessage = "Select Date")]
        [DisplayName("Date and Time")]
        [DataType(DataType.DateTime)]
        public DateTime DateAndTime { get; set; }
        [Required(ErrorMessage = "Enter Available Time")]
        [DisplayName("Available Time")]
        public double AvailableTime { get; set; }
        [DisplayName("Number of seats")]
        public int? NumberOfSeats {  get; set; }
        [DisplayName("Comment")]
        public string? Comment { get; set; }
        [Required(ErrorMessage ="Enter Price")]
        [DisplayName("Price per hour")]
        public double PricePerHour { get; set; }

    }
}
