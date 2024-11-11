using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ReservationsApp.Migrations
{
    /// <inheritdoc />
    public partial class Test2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
