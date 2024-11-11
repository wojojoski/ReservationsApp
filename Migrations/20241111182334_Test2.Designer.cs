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
    [Migration("20241111182334_Test2")]
    partial class Test2
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.2");

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "13416173-64da-4d8d-b9ed-016aa3c3cf1c",
                            ConcurrencyStamp = "13416173-64da-4d8d-b9ed-016aa3c3cf1c",
                            Name = "admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = "128eecbb-4df4-431c-898e-5e2a935b6b2e",
                            ConcurrencyStamp = "128eecbb-4df4-431c-898e-5e2a935b6b2e",
                            Name = "user",
                            NormalizedName = "USER"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClaimType")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("TEXT");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("TEXT");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("TEXT");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("TEXT");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "a701bff1-f6f2-484d-bd19-af319801db22",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "ac89fe58-f80b-4f6e-baf6-87d4f1b6cc78",
                            Email = "michal@gm.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "MICHAL@GM.COM",
                            NormalizedUserName = "ADMIN",
                            PasswordHash = "AQAAAAIAAYagAAAAEMLuL3G2jk0oQNDaRiGESDX/3q+r+Pk8ENwNr/BjbU+EArS6KxcDURL3kZATo+BFbQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "fc4e3ec3-0e68-4792-babd-6a9aa1fe56e9",
                            TwoFactorEnabled = false,
                            UserName = "michal@gm.com"
                        },
                        new
                        {
                            Id = "90b5c92e-a0cf-4581-ad9a-2d304ad2d615",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "64567806-f4da-4239-83fa-00aab489427e",
                            Email = "michael@gm.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "MICHAEL@GM.COM",
                            NormalizedUserName = "MICHAEL",
                            PasswordHash = "AQAAAAIAAYagAAAAECUz7LU8Oks/UTaPet2/HvNCWt1EDkzgMHz+f9M6dM9Mlsmgs2kFDCzvH4QE1ShRJg==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "13bf14f7-6fc9-4c71-842e-94f68968ed68",
                            TwoFactorEnabled = false,
                            UserName = "michael@gm.com"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClaimType")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("RoleId")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);

                    b.HasData(
                        new
                        {
                            UserId = "a701bff1-f6f2-484d-bd19-af319801db22",
                            RoleId = "13416173-64da-4d8d-b9ed-016aa3c3cf1c"
                        },
                        new
                        {
                            UserId = "90b5c92e-a0cf-4581-ad9a-2d304ad2d615",
                            RoleId = "128eecbb-4df4-431c-898e-5e2a935b6b2e"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("Value")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

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

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
