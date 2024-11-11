using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ReservationsApp.Migrations
{
    /// <inheritdoc />
    public partial class AddUserEmailToReservations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "128eecbb-4df4-431c-898e-5e2a935b6b2e", "90b5c92e-a0cf-4581-ad9a-2d304ad2d615" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "13416173-64da-4d8d-b9ed-016aa3c3cf1c", "a701bff1-f6f2-484d-bd19-af319801db22" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "128eecbb-4df4-431c-898e-5e2a935b6b2e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "13416173-64da-4d8d-b9ed-016aa3c3cf1c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "90b5c92e-a0cf-4581-ad9a-2d304ad2d615");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a701bff1-f6f2-484d-bd19-af319801db22");

            migrationBuilder.AddColumn<string>(
                name: "UserEmail",
                table: "Reservations",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "3d0ef646-2dd3-4852-b49b-2c01630b3a52", "3d0ef646-2dd3-4852-b49b-2c01630b3a52", "admin", "ADMIN" },
                    { "980e206f-288c-446a-99ec-8e58f81489fb", "980e206f-288c-446a-99ec-8e58f81489fb", "user", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "70a6e466-e2f8-410b-ad81-88f6dbfebf42", 0, "d296b81a-9b52-42b2-9fb8-943f16b1269c", "michal@gm.com", true, false, null, "MICHAL@GM.COM", "ADMIN", "AQAAAAIAAYagAAAAEKdI/g1v0slYj+TGEl5Bd1cQ7C2bx+QlOYk/TrUxRNjQfxC9cauGv7BABKI1l7WNVQ==", null, false, "936fdba6-85bc-438e-ae2c-1d39c7a7de53", false, "michal@gm.com" },
                    { "b915af1e-4a90-42d7-9704-b40fb812f7af", 0, "c90d8461-70d0-4b5a-ba7c-c6b9b2e747d6", "michael@gm.com", true, false, null, "MICHAEL@GM.COM", "MICHAEL", "AQAAAAIAAYagAAAAEEgj/bgJcOi9w7yphHQ2On5H/dA7YkIYauiYEj1yr+yVYNDBLt9xBQ2sqxL7MBQK1g==", null, false, "d231ca79-611b-493b-bd79-731a1a84fb2d", false, "michael@gm.com" }
                });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 1,
                column: "UserEmail",
                value: "michael@gm.com");

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 2,
                column: "UserEmail",
                value: "michael@gm.com");

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "3d0ef646-2dd3-4852-b49b-2c01630b3a52", "70a6e466-e2f8-410b-ad81-88f6dbfebf42" },
                    { "980e206f-288c-446a-99ec-8e58f81489fb", "b915af1e-4a90-42d7-9704-b40fb812f7af" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3d0ef646-2dd3-4852-b49b-2c01630b3a52", "70a6e466-e2f8-410b-ad81-88f6dbfebf42" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "980e206f-288c-446a-99ec-8e58f81489fb", "b915af1e-4a90-42d7-9704-b40fb812f7af" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3d0ef646-2dd3-4852-b49b-2c01630b3a52");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "980e206f-288c-446a-99ec-8e58f81489fb");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "70a6e466-e2f8-410b-ad81-88f6dbfebf42");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b915af1e-4a90-42d7-9704-b40fb812f7af");

            migrationBuilder.DropColumn(
                name: "UserEmail",
                table: "Reservations");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "128eecbb-4df4-431c-898e-5e2a935b6b2e", "128eecbb-4df4-431c-898e-5e2a935b6b2e", "user", "USER" },
                    { "13416173-64da-4d8d-b9ed-016aa3c3cf1c", "13416173-64da-4d8d-b9ed-016aa3c3cf1c", "admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "90b5c92e-a0cf-4581-ad9a-2d304ad2d615", 0, "64567806-f4da-4239-83fa-00aab489427e", "michael@gm.com", true, false, null, "MICHAEL@GM.COM", "MICHAEL", "AQAAAAIAAYagAAAAECUz7LU8Oks/UTaPet2/HvNCWt1EDkzgMHz+f9M6dM9Mlsmgs2kFDCzvH4QE1ShRJg==", null, false, "13bf14f7-6fc9-4c71-842e-94f68968ed68", false, "michael@gm.com" },
                    { "a701bff1-f6f2-484d-bd19-af319801db22", 0, "ac89fe58-f80b-4f6e-baf6-87d4f1b6cc78", "michal@gm.com", true, false, null, "MICHAL@GM.COM", "ADMIN", "AQAAAAIAAYagAAAAEMLuL3G2jk0oQNDaRiGESDX/3q+r+Pk8ENwNr/BjbU+EArS6KxcDURL3kZATo+BFbQ==", null, false, "fc4e3ec3-0e68-4792-babd-6a9aa1fe56e9", false, "michal@gm.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "128eecbb-4df4-431c-898e-5e2a935b6b2e", "90b5c92e-a0cf-4581-ad9a-2d304ad2d615" },
                    { "13416173-64da-4d8d-b9ed-016aa3c3cf1c", "a701bff1-f6f2-484d-bd19-af319801db22" }
                });
        }
    }
}
