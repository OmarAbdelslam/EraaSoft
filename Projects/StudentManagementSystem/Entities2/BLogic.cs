using Entities.DBWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class BLogic
    {
        public static AppDBcontext db;

        public BLogic() => db = new AppDBcontext();

        public bool AddStudent()
        {
            Console.WriteLine("Enter The user's data");
            Student student = new Student();
            Console.WriteLine("Your ID :");
            student.StudentId = int.Parse(Console.ReadLine());
            Console.WriteLine("Your Name :");
            student.Name = Console.ReadLine();
            Console.WriteLine("Your Age :");
            student.Age = Convert.ToInt16(Console.ReadLine());
            //Console.WriteLine("Add Your Course : \nChoose from them :");
            //foreach (var c in AppDBcontext.courses)
            //{
            //    Console.WriteLine(c);
            //}
            //int choose = Convert.ToInt16(Console.ReadLine());
            //student.Enroll(db.GetCourse(choose));
            return db.AddStudent(student);
        }

        public bool AddCourse()
        {
            Console.WriteLine("Enter Your Course's data");
            Course course = new Course();
            Console.WriteLine("Enter ID :");
            course.CourseId = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter Title :");
            course.Title = Console.ReadLine();
            Console.WriteLine("Enter instractor's id to added it next to the course");
            int instractorid = Convert.ToInt16(Console.ReadLine());
            course.Instructor = db.GetInstructor(instractorid);
            return db.AddCourse(course);
        }

        public bool AddInstractor()
        {
            Console.WriteLine("Enter Instractor's data");
            Instructor instructor = new Instructor();
            Console.WriteLine("Enter ID :");
            instructor.InstructorId = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter Name :");
            instructor.Name = Console.ReadLine();
            Console.WriteLine("Enter Specialization :");
            instructor.Specialization = Console.ReadLine();
            return db.AddInstructor(instructor);
        }

        public void EnrollStudentinSpecifiCourse()
        {
            Console.WriteLine("Enter StudentID and CourseID\n" +
                "Enter StudentID");
            int Sid = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter CourseID ");
            int Cid = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine(db.EnrollStudentInCourse(Sid, Cid));
        }

        public void ShowAllStudents()
        {
            foreach (var s in db.ShowAllStudents())
            {
                Console.WriteLine(s);
            }
        }

        public void ShowAllStudentsWithTheirCourses()
        {
            foreach (var s in db.ShowAllStudents())
            {
                Console.WriteLine(s);
                foreach (var c in s.Courses)
                {
                    Console.WriteLine(">>> " + c);
                }
            }
        }

        public void ShowAllCourses()
        {
            foreach (var c in db.ShowAllCourses())
            {
                Console.WriteLine(c);
            }
        }

        public void ShowAllInstractor()
        {
            foreach (var i in db.ShowAllInstractor())
            {
                Console.WriteLine(i);
            }
        }

        public void GetStudent()
        {
            Console.WriteLine("Enter The Student's data");
            Console.WriteLine("What will you use in searching about student? "); next:
            Console.WriteLine("1. ID User\n2. Name User");
            int choose = Convert.ToInt16(Console.ReadLine());
            if (choose != 1 || choose != 2)
            {
                Console.WriteLine("Error Choose , Try again");
                goto next;
            }
            else if (choose == 1)
            {
                Console.WriteLine("Enter student id");
                int id = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine(db.GetStudent(id));
            }
            else
            {
                Console.WriteLine("Enter student name");
                string Sname = Console.ReadLine();
                Console.WriteLine(db.GetStudent(null, name: Sname));
            }
        }


        public void GetCourse()
        {
                Console.WriteLine("Enter The Course's data");
                Console.WriteLine("What will you use in searching about Course? "); next:
                Console.WriteLine("1. ID Course\n2. Title Course");
                int choose = Convert.ToInt16(Console.ReadLine());
                if (choose != 1 || choose != 2)
                {
                    Console.WriteLine("Error Choose , Try again");
                    goto next;
                }
                else if (choose == 1)
                {
                    Console.WriteLine("Enter Course id");
                    int id = Convert.ToInt16(Console.ReadLine());
                    Console.WriteLine(db.GetCourse(id));
                }
                else
                {
                    Console.WriteLine("Enter Course Title");
                    string Sname = Console.ReadLine();
                    Console.WriteLine(db.GetCourse(null, title: Sname));
                }
        }
    }
}
