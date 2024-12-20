﻿using Microsoft.AspNetCore.Authorization;
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

        public EFReservationsService(AppDbContext context, UserManager<IdentityUser> userManager, IHttpContextAccessor httpContextAccessor)
        {
            _context = context;
            _userManager = userManager;
            _httpContextAccessor = httpContextAccessor;
        }

        public async Task<int> AddReservation(Reservation reservations)
        {
            try
            {
                var userName = _httpContextAccessor.HttpContext?.User.FindFirstValue(ClaimTypes.Name);
                reservations.UserEmail = userName;
                var x = _context.Reservations.Add(ReservationsMapper.ToEntity(reservations));
                _context.SaveChanges();
                return x.Entity.ReservationId;
            }
            catch (Exception ex) { throw new Exception("Error adding reservation", ex); }
        }

        public void UpdateBookedReservation(Reservation model)
        {
            var existingEntity = _context.Reservations.Find(model.ReservationId);
            if (existingEntity != null)
            {
                existingEntity.IsBooked = model.IsBooked;
                existingEntity.BookedByUserId = model.BookedByUserId;
                _context.SaveChanges();
            }
        }
        public void UpdateOfferByOwner(Reservation reservation)
        {
            var offerToEdit = _context.Reservations.Find(reservation.ReservationId);
            if (offerToEdit != null)
            {
                var updatedEntity = ReservationsMapper.ToEntity(reservation);
                _context.Entry(offerToEdit).CurrentValues.SetValues(updatedEntity);
                _context.SaveChanges();
            }
        }

        public void DeleteOffer(int id)
        {
            ReservationsEntity? reservationsEntity = _context.Reservations.Find(id);
            if (reservationsEntity != null)
            {
                _context.Remove(reservationsEntity);
                _context.SaveChanges();
            }
        }

        public Reservation? FindReservationById(int id)
        {
            return ReservationsMapper.FromEntity(_context.Reservations.Find(id));
        }

        public async Task<Reservation?> FindReservationByIdAsync(int id)
        {
            var entity = await _context.Reservations.FindAsync(id);
            return entity != null ? ReservationsMapper.FromEntity(entity) : null;
        }

        //public IQueryable<Reservation> FindAllReservations()
        //{
        //    var reservationsQuery = _context.Reservations
        //        .Where(r => r.IsBooked != true)
        //        .AsNoTracking()
        //        .Select(r => ReservationsMapper.FromEntity(r));

        //    return reservationsQuery;
        //}

        public List<Reservation> FindAllReservations()
        {
            var reservationsList = _context.Reservations
                .Where(r => r.IsBooked != true)
                .AsNoTracking()
                .Select(r => ReservationsMapper.FromEntity(r))
                .ToList();

            return reservationsList;
        }


        public async Task<List<Reservation>> FindReservationsByUserEmailAsync(string userEmail)
        {
            return await _context.Reservations.Where(r => r.UserEmail == userEmail).Select(r => ReservationsMapper.FromEntity(r)).ToListAsync();
        }
        public async Task<List<Reservation>> FindBookedReservationsByUserIdAsync(string userId)
        {
            return await _context.Reservations.AsNoTracking().Where(r => r.BookedByUserId != null && r.BookedByUserId == userId).Select(r => ReservationsMapper.FromEntity(r)).ToListAsync();
        }

    }

    public interface IReservationService
    {
        Task<int> AddReservation(Reservation model);
        public void UpdateBookedReservation(Reservation model);
        public void UpdateOfferByOwner(Reservation reservation);
        public void DeleteOffer(int id);
        public Reservation? FindReservationById(int id);
        Task<Reservation?> FindReservationByIdAsync(int id);
        //IQueryable<Reservation> FindAllReservations();
        List<Reservation> FindAllReservations();
        Task<List<Reservation>> FindReservationsByUserEmailAsync(string userEmail);
        Task<List<Reservation>> FindBookedReservationsByUserIdAsync(string userId);
    }
}
