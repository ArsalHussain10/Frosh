using Microsoft.EntityFrameworkCore.Migrations;

namespace Frosh.Migrations
{
    public partial class worktableupdated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "WorkName",
                table: "Works",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "WorkPath",
                table: "Works",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            
        }
    }
}
