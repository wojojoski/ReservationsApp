﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ReservationsApp.Data;

#nullable disable

namespace ReservationsApp.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240211225242_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.1");

            modelBuilder.Entity("ReservationsApp.Data.Entities.ReservationsEntity", b =>
                {
                    b.Property<int>("ReservationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<double>("AvailableTime")
                        .HasColumnType("REAL");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Comment")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DateAndTime")
                        .HasColumnType("TEXT")
                        .HasColumnName("Date_time");

                    b.Property<int?>("NumberOfSeats")
                        .HasColumnType("INTEGER");

                    b.Property<double>("PricePerHour")
                        .HasColumnType("REAL");

                    b.Property<string>("StreetAndNumber")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Voivodeship")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("ReservationId");

                    b.ToTable("Reservations");

                    b.HasData(
                        new
                        {
                            ReservationId = 1,
                            AvailableTime = 60.0,
                            City = "Warszawa",
                            Comment = "The hall of the Sejm of the RP",
                            DateAndTime = new DateTime(2025, 5, 11, 13, 0, 0, 0, DateTimeKind.Unspecified),
                            NumberOfSeats = 460,
                            PricePerHour = 1000.0,
                            StreetAndNumber = "Wiejska 4",
                            Voivodeship = "Mazowieckie"
                        },
                        new
                        {
                            ReservationId = 2,
                            AvailableTime = 90.0,
                            City = "Tarnobrzeg",
                            Comment = "Cinema hall",
                            DateAndTime = new DateTime(2025, 1, 18, 15, 0, 0, 0, DateTimeKind.Unspecified),
                            NumberOfSeats = 150,
                            PricePerHour = 100.0,
                            StreetAndNumber = "Juliusza Słowackiego 2",
                            Voivodeship = "Podkarpackie"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}