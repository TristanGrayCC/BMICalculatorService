using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BMIApplication.Data.Migrations
{
    public partial class SetupExampleUserData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "eb759a8f-2370-4a71-b4c5-96ae757a7bd4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f8228133-197a-4a22-8a1d-4261b2e02e76");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "goodUserId", 0, "f2c7033e-0ef8-48f9-afb1-bddc0f843baf", null, false, false, null, null, null, "u4Z2lL3jlzg5OzxEXuxgB+iJmRV2XT6/IdigJXFeuGqmLRSB", null, false, null, false, "gooduser" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "af141a60-e18e-4845-8b3f-6dda232d2989", 0, "4c0d727e-8824-470d-9189-feb7b61f6853", null, false, false, new DateTimeOffset(new DateTime(2099, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, "n8rG+gUx0fHoycuvAiCUB8SLrmX61NIIM+RonMF/JBBXVZaF", null, false, null, false, "baduser" });

            migrationBuilder.InsertData(
                table: "UserDatas",
                columns: new[] { "UserId", "DateOfBirth", "Height", "Weight" },
                values: new object[] { "goodUserId", null, 83.4m, 185m });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "af141a60-e18e-4845-8b3f-6dda232d2989");

            migrationBuilder.DeleteData(
                table: "UserDatas",
                keyColumn: "UserId",
                keyValue: "goodUserId");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "goodUserId");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "eb759a8f-2370-4a71-b4c5-96ae757a7bd4", 0, "ad958f36-48cf-44a8-a515-0c07c67672af", null, false, false, null, null, null, "gxFjIQSsFEI7d65EsU8OTm8uuhiC4mcnTwSwA77ylWG0H5s4", null, false, null, false, "gooduser" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "f8228133-197a-4a22-8a1d-4261b2e02e76", 0, "37ecd400-08a2-4111-a87d-70256594dd79", null, false, false, new DateTimeOffset(new DateTime(2099, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, "BRhwxAOBb3VkaaOSOs7w09R3sxxAeIO+MIK0bmfyKw7iTpLu", null, false, null, false, "baduser" });
        }
    }
}
