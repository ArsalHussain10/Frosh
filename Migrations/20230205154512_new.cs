using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Frosh.Migrations
{
    public partial class @new : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Class",
                columns: table => new
                {
                    ClassId = table.Column<int>(nullable: false),
                    SrNo = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    StudentEmail = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    status = table.Column<bool>(nullable: false),
                    JoiningDate = table.Column<string>(unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Class", x => x.SrNo);
                    table.ForeignKey(
                        name: "FK_Class_Classroom_ClassId",
                        column: x => x.ClassId,
                        principalTable: "Classroom",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Class_Student_StudentEmail",
                        column: x => x.StudentEmail,
                        principalTable: "Student",
                        principalColumn: "email",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Class_ClassId",
                table: "Class",
                column: "ClassId");

            migrationBuilder.CreateIndex(
                name: "IX_Class_StudentEmail",
                table: "Class",
                column: "StudentEmail");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Class");
        }
    }
}
