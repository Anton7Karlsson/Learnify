using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Migrations
{
    public partial class CurrentLectureAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "69a7dec1-a086-4d44-9900-87a1fd5008a6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "adbad5aa-4227-4085-92b4-29dd12a98b2f");

            migrationBuilder.AddColumn<int>(
                name: "CurrentLecture",
                table: "UserCourses",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d72fb114-ae72-4765-8930-fc09ab7af875", "0d109794-3570-4acd-a089-4247ecf33ab6", "Student", "STUDENT" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "1555a847-4ccc-413f-8d47-7940fc5ae33a", "f32b18cb-1674-4500-8b7d-4329347db268", "Instructor", "INSTRUCTOR" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1555a847-4ccc-413f-8d47-7940fc5ae33a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d72fb114-ae72-4765-8930-fc09ab7af875");

            migrationBuilder.DropColumn(
                name: "CurrentLecture",
                table: "UserCourses");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "69a7dec1-a086-4d44-9900-87a1fd5008a6", "9720b3c5-20e8-4a10-a395-ce9bf3cb241f", "Student", "STUDENT" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "adbad5aa-4227-4085-92b4-29dd12a98b2f", "5e74093a-c392-4015-bdea-9b988d97f6b2", "Instructor", "INSTRUCTOR" });
        }
    }
}
