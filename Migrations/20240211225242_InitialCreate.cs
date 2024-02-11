using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ReservationsApp.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Reservations",
                columns: table => new
                {
                    ReservationId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Voivodeship = table.Column<string>(type: "TEXT", nullable: false),
                    City = table.Column<string>(type: "TEXT", nullable: false),
                    StreetAndNumber = table.Column<string>(type: "TEXT", nullable: false),
                    Date_time = table.Column<DateTime>(type: "TEXT", nullable: false),
                    AvailableTime = table.Column<double>(type: "REAL", nullable: false),
                    NumberOfSeats = table.Column<int>(type: "INTEGER", nullable: true),
                    Comment = table.Column<string>(type: "TEXT", nullable: true),
                    PricePerHour = table.Column<double>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reservations", x => x.ReservationId);
                });

            migrationBuilder.InsertData(
                table: "Reservations",
                columns: new[] { "ReservationId", "AvailableTime", "City", "Comment", "Date_time", "NumberOfSeats", "PricePerHour", "StreetAndNumber", "Voivodeship" },
                values: new object[,]
                {
                    { 1, 60.0, "Warszawa", "The hall of the Sejm of the RP", new DateTime(2025, 5, 11, 13, 0, 0, 0, DateTimeKind.Unspecified), 460, 1000.0, "Wiejska 4", "Mazowieckie" },
                    { 2, 90.0, "Tarnobrzeg", "Cinema hall", new DateTime(2025, 1, 18, 15, 0, 0, 0, DateTimeKind.Unspecified), 150, 100.0, "Juliusza Słowackiego 2", "Podkarpackie" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Reservations");
        }
    }
}
