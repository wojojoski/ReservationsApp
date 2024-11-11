using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ReservationsApp.Migrations
{
    /// <inheritdoc />
    public partial class Test : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "81a8783a-7bab-4849-bfbd-397df51157c2", "b653c063-d41c-42dc-9682-e287bbb29587" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "5de75cda-bd39-45bf-804c-f0f1ed3aba9f", "bec75c21-f627-4218-b8a7-c3038360a649" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5de75cda-bd39-45bf-804c-f0f1ed3aba9f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "81a8783a-7bab-4849-bfbd-397df51157c2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b653c063-d41c-42dc-9682-e287bbb29587");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bec75c21-f627-4218-b8a7-c3038360a649");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0e8b36a5-daa7-4b86-ab95-f159036c81e1", "0e8b36a5-daa7-4b86-ab95-f159036c81e1", "admin", "ADMIN" },
                    { "8d3a48ce-be8f-4aa8-8e90-d7006407d366", "8d3a48ce-be8f-4aa8-8e90-d7006407d366", "user", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "2dd003aa-3678-493c-afc6-28f872d4e1c2", 0, "42257dca-e3bd-4e0e-99af-47ef8dba4620", "michael@gm.com", true, false, null, "MICHAEL@GM.COM", "MICHAEL", "AQAAAAIAAYagAAAAEN3PMermO5Dxx9W9ly7+7CUCBzxYZBNP0LrdsYlpwY0+DLuotMfPBBosCAjWGULtxQ==", null, false, "9827673e-99d8-4e0e-9cb4-166a088f7097", false, "michael" },
                    { "edea2a84-87ba-4235-9797-618c15bba565", 0, "6bbdc428-1068-4000-8f3e-707a40504ab4", "michal@gm.com", true, false, null, "MICHAL@GM.COM", "ADMIN", "AQAAAAIAAYagAAAAEE0SbFuagy91EEyA+m9HyY8eJ5WC00PT26kpbL6AfGW3aD7QwrW/wT57BU3ozY6jBw==", null, false, "1b750a74-dad7-4805-ad70-5d920101c8e6", false, "michal" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "8d3a48ce-be8f-4aa8-8e90-d7006407d366", "2dd003aa-3678-493c-afc6-28f872d4e1c2" },
                    { "0e8b36a5-daa7-4b86-ab95-f159036c81e1", "edea2a84-87ba-4235-9797-618c15bba565" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "8d3a48ce-be8f-4aa8-8e90-d7006407d366", "2dd003aa-3678-493c-afc6-28f872d4e1c2" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "0e8b36a5-daa7-4b86-ab95-f159036c81e1", "edea2a84-87ba-4235-9797-618c15bba565" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0e8b36a5-daa7-4b86-ab95-f159036c81e1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8d3a48ce-be8f-4aa8-8e90-d7006407d366");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2dd003aa-3678-493c-afc6-28f872d4e1c2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "edea2a84-87ba-4235-9797-618c15bba565");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "5de75cda-bd39-45bf-804c-f0f1ed3aba9f", "5de75cda-bd39-45bf-804c-f0f1ed3aba9f", "admin", "ADMIN" },
                    { "81a8783a-7bab-4849-bfbd-397df51157c2", "81a8783a-7bab-4849-bfbd-397df51157c2", "user", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "b653c063-d41c-42dc-9682-e287bbb29587", 0, "795116cf-507e-49b5-ab39-41d6c48f8c88", "michael@gm.com", true, false, null, "MICHAEL@GM.COM", "MICHAEL", "AQAAAAIAAYagAAAAELcLz1xa3Gwca5kj8d9rypIjYgx2d6XSkqQWmBxa4v+v2iPzNdLIcqjMckJqNeIbsQ==", null, false, "0007cd8d-4d86-4365-9138-cf1a1d3cd13f", false, "michael" },
                    { "bec75c21-f627-4218-b8a7-c3038360a649", 0, "cdae3940-9a1a-474d-bfc1-bed99dd49034", "michal@gm.com", true, false, null, "MICHAL@GM.COM", "ADMIN", "AQAAAAIAAYagAAAAEL+4PabzxUtg37V/MPOhCcR+1GVFFYrMnGchenlaN4t2wO/CYkURc3B4wlMOFyqLvQ==", null, false, "d83a220a-bf36-433f-8e45-8f6ca2ea9c6b", false, "michal" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "81a8783a-7bab-4849-bfbd-397df51157c2", "b653c063-d41c-42dc-9682-e287bbb29587" },
                    { "5de75cda-bd39-45bf-804c-f0f1ed3aba9f", "bec75c21-f627-4218-b8a7-c3038360a649" }
                });
        }
    }
}
