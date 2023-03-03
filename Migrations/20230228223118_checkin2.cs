using Microsoft.EntityFrameworkCore.Migrations;

namespace Frosh.Migrations
{
    public partial class checkin2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "WorkName",
                table: "Works");

            migrationBuilder.DropColumn(
                name: "WorkPaths",
                table: "Works");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "WorkName",
                table: "Works",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "WorkPaths",
                table: "Works",
                nullable: true);
        }
    }
}
