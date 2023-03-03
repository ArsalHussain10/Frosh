﻿// <auto-generated />
using Frosh;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Frosh.Migrations
{
    [DbContext(typeof(froshContext))]
    [Migration("20230207144126_Created File Table")]
    partial class CreatedFileTable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Frosh.Class", b =>
                {
                    b.Property<int>("SrNo")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("SrNo")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ClassId");

                    b.Property<string>("JoiningDate")
                        .HasColumnName("JoiningDate")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<string>("StudentEmail")
                        .HasColumnName("StudentEmail")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<bool>("status")
                        .HasColumnName("status");

                    b.HasKey("SrNo");

                    b.HasIndex("ClassId");

                    b.HasIndex("StudentEmail");

                    b.ToTable("Class");
                });

            modelBuilder.Entity("Frosh.Classroom", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CreationDate")
                        .HasColumnName("creationDate")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<string>("Description");

                    b.Property<string>("Name")
                        .HasColumnName("name")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<int>("NoOfStudents")
                        .HasColumnName("noOfStudents");

                    b.Property<string>("Section");

                    b.Property<string>("TeacherEmail")
                        .IsRequired()
                        .HasColumnName("teacherEmail")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.HasKey("Id");

                    b.HasIndex("TeacherEmail");

                    b.ToTable("Classroom");
                });

            modelBuilder.Entity("Frosh.Models.Comments", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CommentDate");

                    b.Property<string>("CommentText")
                        .IsRequired();

                    b.Property<string>("PersonEmail")
                        .IsRequired();

                    b.Property<int>("PostId");

                    b.HasKey("Id");

                    b.HasIndex("PostId");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("Frosh.Models.File", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ClassroomId");

                    b.Property<string>("CreationDate");

                    b.Property<string>("Path")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("ClassroomId");

                    b.ToTable("File");
                });

            modelBuilder.Entity("Frosh.Models.Post", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ClassroomId");

                    b.Property<string>("PostDate");

                    b.Property<string>("PostText")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("ClassroomId");

                    b.ToTable("Post");
                });

            modelBuilder.Entity("Frosh.Student", b =>
                {
                    b.Property<string>("Email")
                        .HasColumnName("email")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<int>("ClassroomsJoined")
                        .HasColumnName("classroomsJoined");

                    b.Property<string>("Creationdate")
                        .HasColumnName("creationdate")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnName("name")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnName("password")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.HasKey("Email");

                    b.ToTable("Student");
                });

            modelBuilder.Entity("Frosh.Teacher", b =>
                {
                    b.Property<string>("Email")
                        .HasColumnName("email")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<int>("ClassroomsCreated")
                        .HasColumnName("classroomsCreated");

                    b.Property<string>("CreationDate")
                        .HasColumnName("creationDate")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnName("name")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnName("password")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.HasKey("Email");

                    b.ToTable("Teacher");
                });

            modelBuilder.Entity("Frosh.Class", b =>
                {
                    b.HasOne("Frosh.Classroom", "Classroom")
                        .WithMany("Class")
                        .HasForeignKey("ClassId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Frosh.Student", "Student")
                        .WithMany("Class")
                        .HasForeignKey("StudentEmail");
                });

            modelBuilder.Entity("Frosh.Classroom", b =>
                {
                    b.HasOne("Frosh.Teacher", "TeacherEmailNavigation")
                        .WithMany("Classroom")
                        .HasForeignKey("TeacherEmail")
                        .HasConstraintName("TeacherFK");
                });

            modelBuilder.Entity("Frosh.Models.Comments", b =>
                {
                    b.HasOne("Frosh.Models.Post", "Post")
                        .WithMany("Comments")
                        .HasForeignKey("PostId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Frosh.Models.File", b =>
                {
                    b.HasOne("Frosh.Classroom", "Classroom")
                        .WithMany("File")
                        .HasForeignKey("ClassroomId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Frosh.Models.Post", b =>
                {
                    b.HasOne("Frosh.Classroom", "Classroom")
                        .WithMany("Post")
                        .HasForeignKey("ClassroomId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
