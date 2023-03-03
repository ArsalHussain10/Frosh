using Microsoft.EntityFrameworkCore.Migrations;

namespace Frosh.Migrations
{
    public partial class CorrectedPostTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Post_Classroom_ClassroomId",
                table: "Post");

            migrationBuilder.AlterColumn<int>(
                name: "ClassroomId",
                table: "Post",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Post_Classroom_ClassroomId",
                table: "Post",
                column: "ClassroomId",
                principalTable: "Classroom",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Post_Classroom_ClassroomId",
                table: "Post");

            migrationBuilder.AlterColumn<int>(
                name: "ClassroomId",
                table: "Post",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Post_Classroom_ClassroomId",
                table: "Post",
                column: "ClassroomId",
                principalTable: "Classroom",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
