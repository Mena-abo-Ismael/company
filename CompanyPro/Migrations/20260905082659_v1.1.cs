using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CompanyPro.Migrations
{
    /// <inheritdoc />
    public partial class v11 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Did", "Location", "Name" },
                values: new object[,]
                {
                    { 1, "Smart", "SD" },
                    { 2, "Menofia", "OS" }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EId", "Address", "DepartmentId", "ImageUrl", "Name", "Salary" },
                values: new object[,]
                {
                    { 1, "Cairo", 1, null, "Zeniab", 1000m },
                    { 2, "Menofia", 2, null, "MoEbrahim", 1000m },
                    { 3, "Giza", 1, null, "Lena", 1100m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Did",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Did",
                keyValue: 2);
        }
    }
}
