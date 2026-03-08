using System;
using System.Collections.Generic;
using System.Data;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using StudentSystem.Entity;

namespace StudentSystem.DBWork
{
    internal class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext() : base()
        {

        }

        public virtual DbSet<Course> Courses { get; set; }
        public virtual DbSet<Homework> Homeworks { get; set; }
        public virtual DbSet<Resource> Resources { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<StudentCourses> StudentCourses { get; set; }

        private IList<T> Data<T>(string PathFile)
        {
            var read = new List<T>();
            using (StreamReader st = new StreamReader(PathFile))
            {
                var data = st.ReadToEnd();
                read = JsonSerializer.Deserialize<List<T>>(data);
            }
            return read;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-E0A8L3Q;Initial Catalog=StudentSystem;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False");
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<StudentCourses>()
                .HasOne<Student>(sc => sc.student)
                .WithMany(s => s.studentCourses)
                .HasForeignKey(sc => sc.FK_StudentID);

            modelBuilder.Entity<StudentCourses>()
                .HasOne<Course>(sc => sc.course)
                .WithMany(c => c.studentCourses)
                .HasForeignKey(sc => sc.FK_CourseID);


            /*
            modelBuilder.Entity<Student>()
                .HasData(Data<Student>("C:\\Users\\DELL\\Desktop\\EraaSoftAssignment\\EraaSoft\\Projects\\Lectuer 10\\StudentSystem\\MockData\\Student.json"));

            modelBuilder.Entity<Course>()
                .HasData(Data<Course>("C:\\Users\\DELL\\Desktop\\EraaSoftAssignment\\EraaSoft\\Projects\\Lectuer 10\\StudentSystem\\MockData\\Course.json"));

            modelBuilder.Entity<Homework>()
                .HasData(Data<Homework>("C:\\Users\\DELL\\Desktop\\EraaSoftAssignment\\EraaSoft\\Projects\\Lectuer 10\\StudentSystem\\MockData\\HomeWork.json"));

            modelBuilder.Entity<Resource>()
                .HasData(Data<Resource>("C:\\Users\\DELL\\Desktop\\EraaSoftAssignment\\EraaSoft\\Projects\\Lectuer 10\\StudentSystem\\MockData\\Resource.json"));
            */

            modelBuilder.Entity<Student>().HasData(new List<Student>()
            {
                new Student{ Name="Omar", Birthdate= new DateTime(1999,03,21), PhoneNumber=0111111111},
                new Student{Name ="Ahmed", Birthdate = new DateTime(1998,09,23), PhoneNumber=01568545852}
            }
            );

            modelBuilder.Entity<Course>().HasData(new List<Course>
            {

            })
        }

        
    }

    
}
