using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace api.Migrations
{
    /// <inheritdoc />
    public partial class Identity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "885d89d2-1e38-432d-bc42-ff7182a65d62");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9c8187f9-0dc3-4afe-8307-af79163a38ed");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "050da12c-a402-4b25-9ffe-f8f24a458e23", "aa9a4078-e991-4587-bfe6-c6551f2cbfef", "User", "USER" },
                    { "4567f4f5-b1ca-4904-800c-c30129dd656a", "653f6791-12b6-4e69-9bec-718fffadf8c8", "Admin", "ADMIN" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "050da12c-a402-4b25-9ffe-f8f24a458e23");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4567f4f5-b1ca-4904-800c-c30129dd656a");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "885d89d2-1e38-432d-bc42-ff7182a65d62", "880e1ca9-ce75-419c-9ced-1852c0940647", "Admin", "ADMIN" },
                    { "9c8187f9-0dc3-4afe-8307-af79163a38ed", "943648e1-7ff9-4c99-960e-ff6a59d07535", "User", "USER" }
                });
        }
    }
}
