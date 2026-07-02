using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
namespace CampusOs.Dataaccess
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser,ApplicationRole,int>
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }


        public DbSet<Student> Students { get; set; }
        public DbSet<Professor> Professors { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Exam> Exams { get; set; }
        public DbSet<Attendance> Attendances { get; set; }
        public DbSet<StudentRequest> StudentRequests { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Applicant> Applicants { get; set; }
        public DbSet<Announcement> Announcements { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<AcademicWarning> AcademicWarnings { get; set; }



        //protected override void OnConfiguring(DbContextOptionsBuilder OptionsBuilder)
        //{
        //    base.OnConfiguring(OptionsBuilder);
        //    OptionsBuilder.UseSqlServer("Data Source=.;Initial Catalog = CampusOs;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;");
        //}


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // 1. تحديد الـ Primary Key لجدول المواد (لأن اسمه نصي Courses Code)
            modelBuilder.Entity<Course>()
                .HasKey(c => c.CoursesCode);

            // 2. علاقة One-to-Many بين المادة والامتحانات (Has ريليشن)
            // لو في ماده اتمسحت من السيستم هيمسح معاها كل امتحناتها علشان ميسيبش داتا ملهاش لازمه
            modelBuilder.Entity<Exam>()
                .HasOne<Course>()
                .WithMany()
                .HasForeignKey(e => e.CourseCode)
                .OnDelete(DeleteBehavior.Restrict);

            // 3. علاقة One-to-Many بين الطالب وطلباته الإدارية ( Makes ريليشن )
            // لو في طالب اتمسحت (اتفصل مثلا) من السيستم هيمسح معاه كل طلباته علشان ميسيبش داتا ملهاش لازمه برده

            modelBuilder.Entity<StudentRequest>()
                .HasOne<Student>()
                .WithMany()
                .HasForeignKey(sr => sr.StudentId)
                .OnDelete(DeleteBehavior.Restrict);

            // الريليشن بتاع الكورس ونفسه
            modelBuilder.Entity<Course>()
                        .HasOne(c => c.RequiredCourse)       // المادة ليها مادة سابقة 
                        .WithMany()                         // المادة السابقة ممكن تفتح كذا مادة تانية 
                        .HasForeignKey(c => c.RequiredCourseCode) // الربط شغال بكود الماده اللي لازم تخلص الاول
                        .OnDelete(DeleteBehavior.Restrict); // حماية للداتا عشان لو مادة اتمسحت السيستم ميضربش );
                                    
            
            // تعريف المفتاح المركب لجدول الـ Enroll (طالب + مادة + ترم)
            modelBuilder.Entity<Enroll>()
                 .HasKey(e => new { e.StudentId, e.CourseCode, e.SemesterTaken });
        }
    }
}
