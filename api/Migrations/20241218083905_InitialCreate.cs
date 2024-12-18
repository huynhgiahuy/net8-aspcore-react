using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace api.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1550c8ff-1ad8-4e99-9011-4af4786648dc");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ae630291-dabd-448c-884a-865acc038698");

            migrationBuilder.AddColumn<string>(
                name: "UserEmail",
                table: "Comments",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "UserFullName",
                table: "Comments",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "23f41148-fe34-4dca-922f-6a62f9366319", "762562e3-5ffd-4728-a33d-ee372f3ac463", "Admin", "ADMIN" },
                    { "969266f7-94fa-4ac3-8214-ab1401109070", "a405b450-51dc-4bf0-aa68-4485e90e2ee0", "User", "USER" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "23f41148-fe34-4dca-922f-6a62f9366319");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "969266f7-94fa-4ac3-8214-ab1401109070");

            migrationBuilder.DropColumn(
                name: "UserEmail",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "UserFullName",
                table: "Comments");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1550c8ff-1ad8-4e99-9011-4af4786648dc", "5d8eb628-c4a5-439b-8a97-102b13e8c5fe", "Admin", "ADMIN" },
                    { "ae630291-dabd-448c-884a-865acc038698", "9241e869-130d-408a-82bc-ee13fa9cba47", "User", "USER" }
                });
        }
    }
}
