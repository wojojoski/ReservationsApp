using Microsoft.VisualBasic;
using ReservationsApp.Data.Entities;
using ReservationsApp.Models;

namespace ReservationsApp.Mappers
{
    public class ReservationsMapper
    {
        public static Reservations FromEntity(ReservationsEntity entity)
        {
            return new Reservations()
            {
                ReservationId = entity.ReservationId,
                Voivodeship = entity.Voivodeship,
                City = entity.City,
                StreetAndNumber = entity.StreetAndNumber,
                DateAndTime = entity.DateAndTime,
                AvailableTime = entity.AvailableTime,
                NumberOfSeats = entity.NumberOfSeats,
                Comment = entity.Comment,
                PricePerHour = entity.PricePerHour,
            };
        }
        public static ReservationsEntity ToEntity(Reservations model)
        {
            return new ReservationsEntity()
            {
                ReservationId = model.ReservationId,
                Voivodeship = model.Voivodeship,
                City = model.City,
                StreetAndNumber = model.StreetAndNumber,
                DateAndTime = model.DateAndTime,
                AvailableTime = model.AvailableTime,
                NumberOfSeats = model.NumberOfSeats,
                Comment = model.Comment,
                PricePerHour = model.PricePerHour,
            };
        }
    }
}
