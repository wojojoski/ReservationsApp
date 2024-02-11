using Microsoft.EntityFrameworkCore;
using ReservationsApp.Data.Entities;
using ReservationsApp.Models;

namespace ReservationsApp.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<ReservationsEntity> Reservations { get; set; }
        private string DbPath { get; set; }
        public AppDbContext()
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            DbPath = System.IO.Path.Join(path, "reservations.db");
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite($"Data Source={DbPath}");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ReservationsEntity>().HasData(
                new Reservations()
                {
                    ReservationId = 1,
                    Voivodeship = "Mazowieckie",
                    City = "Warszawa",
                    StreetAndNumber = "Wiejska 4",
                    DateAndTime = new DateTime(2025, 05, 11, 13, 00, 00),
                    AvailableTime = 60,
                    NumberOfSeats = 460,
                    Comment = "The hall of the Sejm of the RP",
                    PricePerHour = 1000
                },
                new Reservations()
                {
                    ReservationId = 2,
                    Voivodeship = "Podkarpackie",
                    City = "Tarnobrzeg",
                    StreetAndNumber = "Juliusza Słowackiego 2",
                    DateAndTime = new DateTime(2025, 01, 18, 15, 00, 00),
                    AvailableTime = 90,
                    NumberOfSeats = 150,
                    Comment = "Cinema hall",
                    PricePerHour = 100
                }
            );
        }
    }
}
