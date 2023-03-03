using Microsoft.EntityFrameworkCore.Migrations;

namespace Frosh.Migrations
{
    public partial class CorrectedCommentsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PersonId",
                table: "Comments");

            migrationBuilder.AddColumn<string>(
                name: "PersonEmail",
                table: "Comments",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PersonEmail",
                table: "Comments");

            migrationBuilder.AddColumn<int>(
                name: "PersonId",
                table: "Comments",
                nullable: false,
                defaultValue: 0);
        }
    }
}
