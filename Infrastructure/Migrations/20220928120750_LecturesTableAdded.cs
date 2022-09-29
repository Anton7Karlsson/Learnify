using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Migrations
{
    public partial class LecturesTableAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "12828e76-dd1e-49e0-95f7-e7324d3fdd81");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "16516ea8-875a-4a26-b07c-0555d015c2b8");

            migrationBuilder.CreateTable(
                name: "Sections",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    CourseId = table.Column<Guid>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sections", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sections_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Lectures",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(type: "TEXT", nullable: true),
                    Url = table.Column<string>(type: "TEXT", nullable: true),
                    SectionId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lectures", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Lectures_Sections_SectionId",
                        column: x => x.SectionId,
                        principalTable: "Sections",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "69a7dec1-a086-4d44-9900-87a1fd5008a6", "9720b3c5-20e8-4a10-a395-ce9bf3cb241f", "Student", "STUDENT" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "adbad5aa-4227-4085-92b4-29dd12a98b2f", "5e74093a-c392-4015-bdea-9b988d97f6b2", "Instructor", "INSTRUCTOR" });

            migrationBuilder.CreateIndex(
                name: "IX_Lectures_SectionId",
                table: "Lectures",
                column: "SectionId");

            migrationBuilder.CreateIndex(
                name: "IX_Sections_CourseId",
                table: "Sections",
                column: "CourseId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Lectures");

            migrationBuilder.DropTable(
                name: "Sections");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "69a7dec1-a086-4d44-9900-87a1fd5008a6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "adbad5aa-4227-4085-92b4-29dd12a98b2f");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "16516ea8-875a-4a26-b07c-0555d015c2b8", "cf4991cc-e461-44d5-b5de-df2bb55d27de", "Student", "STUDENT" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "12828e76-dd1e-49e0-95f7-e7324d3fdd81", "21e3b05e-b875-4c75-8cc2-600fdc7c3473", "Instructor", "INSTRUCTOR" });
        }
    }
}
