using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace ReservationsApp.Data.Entities
{
    public class ReservationsEntity
    {
        [Key]
        public int ReservationId { get; set; }

        public string Voivodeship { get; set; }

        public string City { get; set; }

        public string StreetAndNumber { get; set; }

        [Column("Date_time")]
        public DateTime DateAndTime { get; set; }
        public double AvailableTime { get; set; }

        public int? NumberOfSeats { get; set; }

        public string? Comment { get; set; }
        public double PricePerHour { get; set; }
        public string UserEmail { get; set; }
        public bool IsBooked {  get; set; }
        public string? BookedByUserId {  get; set; }
    }
}
