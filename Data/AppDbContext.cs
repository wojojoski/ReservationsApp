using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ReservationsApp.Data.Entities;
using ReservationsApp.Models;

namespace ReservationsApp.Data
{
    public class AppDbContext : IdentityDbContext<IdentityUser>
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
            base.OnModelCreating(modelBuilder);


            string ADMIN_ID = Guid.NewGuid().ToString();
            string ROLE_ID = Guid.NewGuid().ToString();
            string USER_ID = Guid.NewGuid().ToString();
            string USER_ROLE_ID = Guid.NewGuid().ToString();

            //Adding admin role
            modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Name = "admin",
                NormalizedName = "ADMIN",
                Id = ROLE_ID,
                ConcurrencyStamp = ROLE_ID
            });

            //Adding user role
            modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Name = "user",
                NormalizedName = "USER",
                Id = USER_ROLE_ID,
                ConcurrencyStamp = USER_ROLE_ID
            });

            //Creating user
            var user = new IdentityUser
            {
                Id = USER_ID,
                Email = "michael@gm.com",
                EmailConfirmed = true,
                UserName = "michael@gm.com",
                NormalizedUserName = "MICHAEL",
                NormalizedEmail = "MICHAEL@GM.COM"
            };

            //Creating admin as a user 
            var admin = new IdentityUser
            {
                Id = ADMIN_ID,
                Email = "michal@gm.com",
                EmailConfirmed = true,
                UserName = "michal@gm.com",
                NormalizedUserName = "ADMIN",
                NormalizedEmail = "MICHAL@GM.COM"
            };

            //Password hasing
            PasswordHasher<IdentityUser> passwordHasher = new PasswordHasher<IdentityUser>();

            user.PasswordHash = passwordHasher.HashPassword(user, "QWERTY");
            admin.PasswordHash = passwordHasher.HashPassword(admin, "1234abcd!@#$ABCD");

            //PasswordHasher<IdentityUser> phUser = new PasswordHasher<IdentityUser>();
            //user.PasswordHash = phUser.HashPassword(user, "QWERTY");

            //PasswordHasher<IdentityUser> ph = new PasswordHasher<IdentityUser>();
            //admin.PasswordHash = ph.HashPassword(admin, "1234abcd!@#$ABCD");

            //Save user
            modelBuilder.Entity<IdentityUser>().HasData(admin);

            modelBuilder.Entity<IdentityUser>().HasData(user);

            //Account created from website 
            //Login: Patryk@gm.com
            //Password:Patryk1!

            //assigning an administrator role to a user
            modelBuilder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = ROLE_ID,
                UserId = ADMIN_ID,
            });

            //assigning an user role to a user
            modelBuilder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = USER_ROLE_ID,
                UserId = USER_ID
            });

            modelBuilder.Entity<ReservationsEntity>().HasData(
                new Reservation()
                {
                    ReservationId = 1,
                    Voivodeship = "Mazowieckie",
                    City = "Warszawa",
                    StreetAndNumber = "Wiejska 4",
                    DateAndTime = new DateTime(2025, 05, 11, 13, 00, 00),
                    AvailableTime = 60,
                    NumberOfSeats = 460,
                    Comment = "The hall of the Sejm of the RP",
                    PricePerHour = 1000,
                    UserEmail = "michael@gm.com"
                },
                new Reservation()
                {
                    ReservationId = 2,
                    Voivodeship = "Podkarpackie",
                    City = "Tarnobrzeg",
                    StreetAndNumber = "Juliusza Słowackiego 2",
                    DateAndTime = new DateTime(2025, 01, 18, 15, 00, 00),
                    AvailableTime = 90,
                    NumberOfSeats = 150,
                    Comment = "Cinema hall",
                    PricePerHour = 100,
                    UserEmail = "michael@gm.com"
                }
            );
        }
    }
}
