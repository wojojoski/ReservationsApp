using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.CodeAnalysis.Elfie.Model.Strings;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using ReservationsApp.Data;
using ReservationsApp.Data.Entities;
using ReservationsApp.Mappers;
using ReservationsApp.Models;
using System;
using System.Security.Claims;
using System.Security.Principal;

namespace ReservationsApp.Services
{
    public class EFReservationsService : IReservationService
    {
        private readonly AppDbContext _context;

        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly UserManager<IdentityUser> _userManager;

        public EFReservationsService (AppDbContext context, UserManager<IdentityUser> userManager, IHttpContextAccessor httpContextAccessor)
        {
            _context = context;
            _userManager = userManager;
            _httpContextAccessor = httpContextAccessor;
        }

        public async Task<int> AddReservation(Reservation reservations)
        {
            var userName = _httpContextAccessor.HttpContext?.User.FindFirstValue(ClaimTypes.Name);
            reservations.UserEmail = userName;
            var x = _context.Reservations.Add(ReservationsMapper.ToEntity(reservations));
            _context.SaveChanges();
            return x.Entity.ReservationId;
        }

        public void UpdateReservation(Reservation model)
        {
            _context.Reservations.Update(ReservationsMapper.ToEntity(model));
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            ReservationsEntity? reservationsEntity = _context.Reservations.Find(id);
            if(reservationsEntity != null)
            {
                _context.Remove(reservationsEntity);
                _context.SaveChanges();
            }
        }

        public Reservation? FindReservationById(int id)
        {
            return ReservationsMapper.FromEntity(_context.Reservations.Find(id));
        }

        public List<Reservation> FindAllReservations()
        {
            return _context.Reservations.Select(x => ReservationsMapper.FromEntity(x)).ToList();
        }
        
        public async Task<List<Reservation>> FindReservationsByUserEmailAsync(string userEmail)
        {
            return await _context.Reservations.Where(r => r.UserEmail == userEmail).Select(r => ReservationsMapper.FromEntity(r)).ToListAsync();
        }
    }

    public interface IReservationService
    {
        Task<int> AddReservation(Reservation model);
        public void UpdateReservation(Reservation model);
        public void Delete(int id);
        public Reservation? FindReservationById(int id);
        List<Reservation> FindAllReservations();
        Task<List<Reservation>> FindReservationsByUserEmailAsync(string userEmail);
    }
}
