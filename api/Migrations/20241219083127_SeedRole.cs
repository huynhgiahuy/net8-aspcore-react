using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace api.Migrations
{
    /// <inheritdoc />
    public partial class SeedRole : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { "7b82e1c5-d940-4fa4-a199-460b028509c7", "5952de97-f7da-421c-96f6-9f7c026dcd20", "Admin", "ADMIN" },
                    { "913f28e5-8511-425f-90b8-8548e7946236", "62c79ef5-dcbf-4b11-af13-198e7a2cfd6d", "User", "USER" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7b82e1c5-d940-4fa4-a199-460b028509c7");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "913f28e5-8511-425f-90b8-8548e7946236");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "050da12c-a402-4b25-9ffe-f8f24a458e23", "aa9a4078-e991-4587-bfe6-c6551f2cbfef", "User", "USER" },
                    { "4567f4f5-b1ca-4904-800c-c30129dd656a", "653f6791-12b6-4e69-9bec-718fffadf8c8", "Admin", "ADMIN" }
                });
        }
    }
}
