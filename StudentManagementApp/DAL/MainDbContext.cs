using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DAL;
using Microsoft.IdentityModel.Protocols;
using System.Configuration;

namespace DAL
{
    public class MainDbContext : DbContext
    {
        public DbSet<tblUsers> tblUsers { get; set; }
        public DbSet<tblStudents> tblStudents { get; set; }
        public DbSet<tblCourses> tblCourses { get; set; }
        public DbSet<tblStudentCourse> tblStudentCourses { get; set; }
        public DbSet<tblDepartment> tblDepartments { get; set; }
        public DbSet<tblInstructor> tblInstructors { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["SchoolDBConnectionString"]?.ConnectionString;

            if (string.IsNullOrEmpty(connectionString))
            {
                throw new Exception("Connection string 'SchoolDBConnectionString' is missing or empty. Check App.config!");
            }

            optionsBuilder.UseSqlServer(connectionString);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<tblUsers>()
                .HasKey(u => u.UserId); // Define UserId as the primary key

            modelBuilder.Entity<tblStudents>()
                .HasKey(s => s.StudentID); // Define StudentId as the primary key

            modelBuilder.Entity<tblCourses>()
                .HasKey(c => c.CourseID); // Define CourseId as the primary key

            modelBuilder.Entity<tblDepartment>()
                .HasKey(c => c.DepartmentID); // Define DepartmentId as the primary key

            modelBuilder.Entity<tblInstructor>()
                .HasKey(c => c.InstructorID); // Define InstructorId as the primary key

            modelBuilder.Entity<tblInstructor>()
                .HasOne(i => i.tblDepartment)
                .WithMany()
                .HasForeignKey(i => i.DepartmentID);

            modelBuilder.Entity<tblCourses>()
                .HasOne(c => c.tblInstructor)
                .WithMany(i => i.tblCourses)
                .HasForeignKey(c => c.InstructorID);

            modelBuilder.Entity<tblCourses>()
                .HasOne(c => c.tblDepartment)
                .WithMany(d => d.tblCourses)
                .HasForeignKey(c => c.DepartmentID);

            modelBuilder.Entity<tblStudentCourse>()
                .HasKey(sc => new { sc.StudentID, sc.CourseID });

            modelBuilder.Entity<tblStudentCourse>()
                .HasOne(sc => sc.tblStudents)
                .WithMany(s => s.tblStudentCourse)
                .HasForeignKey(sc => sc.StudentID);

            modelBuilder.Entity<tblStudentCourse>()
                .HasOne(sc => sc.tblCourses)
                .WithMany(c => c.tblStudentCourse)
                .HasForeignKey(sc => sc.CourseID);
        }


    }
}
