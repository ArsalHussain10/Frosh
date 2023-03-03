using Microsoft.EntityFrameworkCore.Migrations;

namespace Frosh.Migrations
{
    public partial class Updateworktableagain : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Path",
                table: "Works",
                newName: "WorkPaths");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
           
        }
    }
}
