using Microsoft.EntityFrameworkCore.Migrations;

namespace EntityCodeFirst.Migrations
{
    public partial class dataMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Id", "Budget", "Location", "Name", "Type" },
                values: new object[] { 1, 1000000000000.0, "Midland, MI", "Research & Development", "Science" });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Id", "Budget", "Location", "Name", "Type" },
                values: new object[] { 2, 2000000000000.0, "Dhaka, Bangladesh", "Human Resources", "Administrative" });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Id", "Budget", "Location", "Name", "Type" },
                values: new object[] { 3, 53.0, "Party City, USA", "Fun Department", "Administrative" });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "DepartmentId", "Email", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1, 1, "venkman@ghostbusters.co", "Peter", "Venkman" },
                    { 2, 2, "stantz@ghostbusters.co", "Raymond", "Stantz" },
                    { 3, 2, "spengler@ghostbusters.co", "Egon", "Spengler" },
                    { 4, 2, "slimer@ghosts.co", "Slimer", null },
                    { 5, 3, "barrett@nyphil.co", "Dana", "Barrett" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
