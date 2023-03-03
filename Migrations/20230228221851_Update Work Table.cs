using Microsoft.EntityFrameworkCore.Migrations;

namespace Frosh.Migrations
{
    public partial class UpdateWorkTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "WorkPaths",
                table: "Works",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "WorkName",
                table: "Works",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            
        }
    }
}
