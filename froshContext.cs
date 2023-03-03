using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Frosh.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage;

namespace Frosh
{
    public class froshContext : DbContext
    {
        public froshContext()
        {
        }

        public froshContext(DbContextOptions<froshContext> options)
            : base(options)
        {
            try
            {
                var databaseCreater = Database.GetService<IDatabaseCreator>() as RelationalDatabaseCreator;
                if(databaseCreater!=null)
                {
                    if (!databaseCreater.Exists())
                    {
                        databaseCreater.Create();

                    }
                    if(!HasTables())
                    {
                        databaseCreater.CreateTables();
                    }
                    
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        private bool HasTables()
        {
            return Model.GetEntityTypes().Any(t => t.Relational().TableName != null);
        }

        public virtual DbSet<Classroom> Classroom { get; set; }
        public virtual DbSet<Student> Student { get; set; }
        public virtual DbSet<Teacher> Teacher { get; set; }
        public virtual DbSet<Class> Class { get; set; }
        public virtual DbSet<Post> Post { get; set; }
        public virtual DbSet<Comments> Comments { get; set; }
        public virtual DbSet<File> File { get; set; }
        public virtual DbSet<Work> Works { get; set; }

        

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=frosh;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Classroom>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreationDate)
                    .HasColumnName("creationDate")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NoOfStudents).HasColumnName("noOfStudents");

                entity.Property(e => e.TeacherEmail)
                    .IsRequired()
                    .HasColumnName("teacherEmail")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.TeacherEmailNavigation)
                    .WithMany(p => p.Classroom)
                    .HasForeignKey(d => d.TeacherEmail)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("TeacherFK");
            });

            modelBuilder.Entity<Student>(entity =>
            {
                entity.HasKey(e => e.Email);

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.ClassroomsJoined).HasColumnName("classroomsJoined");

                entity.Property(e => e.Creationdate)
                    .HasColumnName("creationdate")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasColumnName("password")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Teacher>(entity =>
            {
                entity.HasKey(e => e.Email);

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.ClassroomsCreated).HasColumnName("classroomsCreated");

                entity.Property(e => e.CreationDate)
                    .HasColumnName("creationDate")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasColumnName("password")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });
            modelBuilder.Entity<Class>(entity =>
            {
                entity.HasKey(e => e.SrNo);

                entity.Property(e => e.SrNo)
                    .HasColumnName("SrNo")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.StudentEmail)
                    .HasColumnName("StudentEmail")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.status)
                    .HasColumnName("status");

                entity.Property(e => e.JoiningDate)
                    .HasColumnName("JoiningDate")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Student)
                    .WithMany(p => p.Class)
                    .HasForeignKey(d => d.StudentEmail);
                entity.HasOne(d => d.Classroom)
                    .WithMany(p => p.Class)
                    .HasForeignKey(d => d.ClassId);
            });
        }
    }
}
