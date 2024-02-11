using ReservationsApp.Data;
using ReservationsApp.Interfaces;
using ReservationsApp.Mappers;
using ReservationsApp.Models;
using System;

namespace ReservationsApp.Services
{
    public class EFReservationsService : IReservationService
    {
        private readonly AppDbContext _context;

        public EFReservationsService (AppDbContext context)
        {
            _context = context;
        }
        public int AddReservation(Reservations reservations)
        {
            var e = _context.Reservations.Add(ReservationsMapper.ToEntity(reservations));
            _context.SaveChanges();
            return e.Entity.ReservationId;
        }

        public List<Reservations> FindAllReservations()
        {
            return _context.Reservations.Select(e => ReservationsMapper.FromEntity(e)).ToList();
        }
    }
}
