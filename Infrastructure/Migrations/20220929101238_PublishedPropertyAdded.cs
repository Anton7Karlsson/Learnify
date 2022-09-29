using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Migrations
{
    public partial class PublishedPropertyAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1555a847-4ccc-413f-8d47-7940fc5ae33a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d72fb114-ae72-4765-8930-fc09ab7af875");

            migrationBuilder.AddColumn<bool>(
                name: "Published",
                table: "Courses",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "fb22eb47-c413-4354-9e41-c8ac6afb2da9", "a376f740-0441-4747-9f70-93529a872afd", "Student", "STUDENT" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b6e63e1e-ad28-4058-852b-180fbffe308f", "fe1d9039-3cc3-4b42-95f7-a6e7e7f7b240", "Instructor", "INSTRUCTOR" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b6e63e1e-ad28-4058-852b-180fbffe308f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fb22eb47-c413-4354-9e41-c8ac6afb2da9");

            migrationBuilder.DropColumn(
                name: "Published",
                table: "Courses");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d72fb114-ae72-4765-8930-fc09ab7af875", "0d109794-3570-4acd-a089-4247ecf33ab6", "Student", "STUDENT" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "1555a847-4ccc-413f-8d47-7940fc5ae33a", "f32b18cb-1674-4500-8b7d-4329347db268", "Instructor", "INSTRUCTOR" });
        }
    }
}
