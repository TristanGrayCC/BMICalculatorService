using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BMIApplication.Data.Migrations
{
    public partial class UserSetup : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "eb759a8f-2370-4a71-b4c5-96ae757a7bd4", 0, "ad958f36-48cf-44a8-a515-0c07c67672af", null, false, false, null, null, null, "gxFjIQSsFEI7d65EsU8OTm8uuhiC4mcnTwSwA77ylWG0H5s4", null, false, null, false, "gooduser" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "f8228133-197a-4a22-8a1d-4261b2e02e76", 0, "37ecd400-08a2-4111-a87d-70256594dd79", null, false, false, new DateTimeOffset(new DateTime(2099, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, "BRhwxAOBb3VkaaOSOs7w09R3sxxAeIO+MIK0bmfyKw7iTpLu", null, false, null, false, "baduser" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "eb759a8f-2370-4a71-b4c5-96ae757a7bd4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f8228133-197a-4a22-8a1d-4261b2e02e76");
        }
    }
}
