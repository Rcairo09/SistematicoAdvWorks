using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAdvWorks.Data.Migrations
{
    public partial class Migracion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b6055a1c-8696-4299-8050-09a99bae0399", "58d307ca-f2f3-4e14-b3b1-35ee64053c29", "Administrador", "ADMINISTRADOR" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "1eef0ac1-cdac-46fb-a5b2-33c127ae7b75", 0, "f6fb9d38-3cfb-476a-9114-0e46296002bc", "ApplicationUser", "Rcairo09@gmail.com", true, false, null, "RCAIRO09@GMAIL.COM", "RCAIRO09@GMAIL.COM", "AQAAAAEAACcQAAAAEND/jelEZtSy9NgdHrbVnw1hArI7IMLkVQ87BUbFPpbqx+c1uSzRjV5FrkiBa3lJlQ==", null, false, "77c73bba-49ca-4541-876a-9139f0f8bb7d", false, "Rcairo09@gmail.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "b6055a1c-8696-4299-8050-09a99bae0399", "1eef0ac1-cdac-46fb-a5b2-33c127ae7b75" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b6055a1c-8696-4299-8050-09a99bae0399", "1eef0ac1-cdac-46fb-a5b2-33c127ae7b75" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b6055a1c-8696-4299-8050-09a99bae0399");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1eef0ac1-cdac-46fb-a5b2-33c127ae7b75");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "AspNetUsers");
        }
    }
}
