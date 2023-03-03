using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Frosh.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.CreateTable(
            //    name: "Student",
            //    columns: table => new
            //    {
            //        email = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
            //        name = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
            //        password = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
            //        creationdate = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
            //        classroomsJoined = table.Column<int>(nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Student", x => x.email);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Teacher",
            //    columns: table => new
            //    {
            //        email = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
            //        name = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
            //        password = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
            //        classroomsCreated = table.Column<int>(nullable: false),
            //        creationDate = table.Column<string>(unicode: false, maxLength: 50, nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Teacher", x => x.email);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Classroom",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
            //        name = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
            //        teacherEmail = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
            //        noOfStudents = table.Column<int>(nullable: false),
            //        creationDate = table.Column<string>(unicode: false, maxLength: 50, nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Classroom", x => x.id);
            //        table.ForeignKey(
            //            name: "TeacherFK",
            //            column: x => x.teacherEmail,
            //            principalTable: "Teacher",
            //            principalColumn: "email",
            //            onDelete: ReferentialAction.Restrict);
            //    });

            //migrationBuilder.CreateIndex(
            //    name: "IX_Classroom_teacherEmail",
            //    table: "Classroom",
            //    column: "teacherEmail");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
        }
    }
}
