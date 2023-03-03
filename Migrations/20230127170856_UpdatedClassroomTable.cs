using Microsoft.EntityFrameworkCore.Migrations;

namespace Frosh.Migrations
{
    public partial class UpdatedClassroomTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Classroom",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Section",
                table: "Classroom",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Classroom");

            migrationBuilder.DropColumn(
                name: "Section",
                table: "Classroom");
        }
    }
}
