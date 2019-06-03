using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BMIApplication.Data.Migrations
{
    public partial class SetupExampleUserDataFix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "af141a60-e18e-4845-8b3f-6dda232d2989");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "goodUserId",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "765014eb-283f-440e-a4fe-4914a9f7d94c", "bnAhdoXVgG7p5GaL0pDHnp9clZPmmBZBNkJAXqriKA2ea9TI" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "f7b50b15-7006-4b95-8fa8-1eae73832130", 0, "c44f5535-239e-4cab-8959-5d1bf452f36d", null, false, false, new DateTimeOffset(new DateTime(2099, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, "urgFaCp5LRc/eTl4eI8A18U6zfJrUVtX8PEqQR6DWWex908E", null, false, null, false, "baduser" });

            migrationBuilder.UpdateData(
                table: "UserDatas",
                keyColumn: "UserId",
                keyValue: "goodUserId",
                columns: new[] { "Height", "Weight" },
                values: new object[] { 1.85m, 83.5m });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f7b50b15-7006-4b95-8fa8-1eae73832130");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "goodUserId",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f2c7033e-0ef8-48f9-afb1-bddc0f843baf", "u4Z2lL3jlzg5OzxEXuxgB+iJmRV2XT6/IdigJXFeuGqmLRSB" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "af141a60-e18e-4845-8b3f-6dda232d2989", 0, "4c0d727e-8824-470d-9189-feb7b61f6853", null, false, false, new DateTimeOffset(new DateTime(2099, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, "n8rG+gUx0fHoycuvAiCUB8SLrmX61NIIM+RonMF/JBBXVZaF", null, false, null, false, "baduser" });

            migrationBuilder.UpdateData(
                table: "UserDatas",
                keyColumn: "UserId",
                keyValue: "goodUserId",
                columns: new[] { "Height", "Weight" },
                values: new object[] { 83.4m, 185m });
        }
    }
}
