using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ReservationsApp.Migrations
{
    /// <inheritdoc />
    public partial class UpdateTemplateReservations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "4652ba4d-6425-49fa-8dd3-c6407bb22deb", "28d2907e-f3e7-419e-b398-b701cd12ec17" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "d6b583d4-65e5-4cea-bbed-b83aa4c5bb65", "6817043c-ae20-4472-a9b8-596cd2920a9f" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4652ba4d-6425-49fa-8dd3-c6407bb22deb");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d6b583d4-65e5-4cea-bbed-b83aa4c5bb65");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "28d2907e-f3e7-419e-b398-b701cd12ec17");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6817043c-ae20-4472-a9b8-596cd2920a9f");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "76dbb800-df58-48db-9646-35cfab0df549", "76dbb800-df58-48db-9646-35cfab0df549", "admin", "ADMIN" },
                    { "cdcff2eb-69db-43ca-9217-82d62bc782d5", "cdcff2eb-69db-43ca-9217-82d62bc782d5", "user", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "4c497e71-5892-4161-b807-22f33beaf647", 0, "0737186e-b19b-4c54-862b-39f8401dc403", "michael@gm.com", true, false, null, "MICHAEL@GM.COM", "MICHAEL", "AQAAAAIAAYagAAAAEH1Rvhh2iglDreMEZhSFyQjSC4WiItKJ+5MYuYqH2e2kYIH58lJXFRTmnM1qkdb9Sg==", null, false, "c9b2ec46-04c9-4c01-9ecf-d026acb9ab72", false, "michael@gm.com" },
                    { "ab1a7842-5dcb-4507-aa79-bbd6b572d0ff", 0, "b64c408e-70eb-4701-bb43-270d118f2535", "michal@gm.com", true, false, null, "MICHAL@GM.COM", "ADMIN", "AQAAAAIAAYagAAAAEBHR2Dy4yVLAcI6kHkfMvVt9WPgnGkAdqR7JpbKgRMkExghXS4zyZXRGsk5aozcMBw==", null, false, "5d9aecbc-85e2-41e7-8ef4-51fb7dc0aaeb", false, "michal@gm.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "cdcff2eb-69db-43ca-9217-82d62bc782d5", "4c497e71-5892-4161-b807-22f33beaf647" },
                    { "76dbb800-df58-48db-9646-35cfab0df549", "ab1a7842-5dcb-4507-aa79-bbd6b572d0ff" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "cdcff2eb-69db-43ca-9217-82d62bc782d5", "4c497e71-5892-4161-b807-22f33beaf647" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "76dbb800-df58-48db-9646-35cfab0df549", "ab1a7842-5dcb-4507-aa79-bbd6b572d0ff" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "76dbb800-df58-48db-9646-35cfab0df549");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cdcff2eb-69db-43ca-9217-82d62bc782d5");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4c497e71-5892-4161-b807-22f33beaf647");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ab1a7842-5dcb-4507-aa79-bbd6b572d0ff");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "4652ba4d-6425-49fa-8dd3-c6407bb22deb", "4652ba4d-6425-49fa-8dd3-c6407bb22deb", "user", "USER" },
                    { "d6b583d4-65e5-4cea-bbed-b83aa4c5bb65", "d6b583d4-65e5-4cea-bbed-b83aa4c5bb65", "admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "28d2907e-f3e7-419e-b398-b701cd12ec17", 0, "1a705beb-6f8c-4287-b941-2e9a8b32417a", "michael@gm.com", true, false, null, "MICHAEL@GM.COM", "MICHAEL", "AQAAAAIAAYagAAAAEIhOmhujCejIbxszcQu6Xc2lAm2GjFWJROZVamAhwSwk/qUsEQw7vfI0if3l90JbRg==", null, false, "6773a884-c011-4643-9e1e-8bc328c3a9fe", false, "michael@gm.com" },
                    { "6817043c-ae20-4472-a9b8-596cd2920a9f", 0, "a7c3aa4b-ae57-4a94-a283-76d3b8d21cbc", "michal@gm.com", true, false, null, "MICHAL@GM.COM", "ADMIN", "AQAAAAIAAYagAAAAEBCf9w3/Pd72h6CzM+JS00aUsjSWs8KsbTn1tIJwe8fS+9Jli1iJIZ3xcfNo8LcFow==", null, false, "d0325331-70ec-44ac-b3e5-ae795ae15866", false, "michal@gm.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "4652ba4d-6425-49fa-8dd3-c6407bb22deb", "28d2907e-f3e7-419e-b398-b701cd12ec17" },
                    { "d6b583d4-65e5-4cea-bbed-b83aa4c5bb65", "6817043c-ae20-4472-a9b8-596cd2920a9f" }
                });
        }
    }
}
