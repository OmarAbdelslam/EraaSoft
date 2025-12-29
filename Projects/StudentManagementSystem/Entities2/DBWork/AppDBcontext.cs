using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentManagementSystem.Exceptions;

namespace Entities.DBWork
{
    public class AppDBcontext
    {
        public static IList<Student> students { get; set; }

        public static IList<Course> courses { get; set; }

        public static IList<Instructor> instructors { get; set; }


        public AppDBcontext() 
        {
            students = new List<Student>();
            courses = new List<Course>();
            instructors = new List<Instructor>();
        }



        public bool AddStudent(Student student)
        {
            if (student == null) throw new ArgumentNullException();
            if(student.GetType() != typeof(Student)) return false;
            students.Add(student);
            return true;
        }

        public bool AddCourse(Course course)
        {
            if (course == null) throw new ArgumentNullException();
            if (course.GetType() != typeof(Course)) return false;
            courses.Add(course);
            return true;
        }

        public bool AddInstructor(Instructor instructor)
        {
            if (instructor == null) throw new ArgumentNullException();
            if (instructor.GetType() != typeof(Instructor)) return false;
            instructors.Add(instructor);
            return true;
        }

        public Student GetStudent(int? id,string name = "no name")
        {
            if(id == null && name == "no name") throw new ArgumentNullException();
            var student = students.FirstOrDefault(s=> s.StudentId == id) ?? students.First(s=>s.Name == name);
            if(student == null) throw new StudentNotFoundException();
            return student;
        }

        public Student GetStudentWithCourses(int? id)
        {
            if (id != null) throw new ArgumentNullException();
            var student = students.FirstOrDefault(s => s.StudentId == id);
            if (student == null) throw new StudentNotFoundException();
            return student;
        }

        public Course GetCourse(int? id , string title = "no name")
        {
            if (id == null && title =="no name") throw new ArgumentNullException();
            var course = courses.FirstOrDefault(c => c.CourseId == id) ?? courses.FirstOrDefault(c => c.Title == title);
            if (course == null) throw new CourseNotFoundException();
            return course;
        }

        public Instructor GetInstructor(int? id)
        {
            if (id == null) throw new ArgumentNullException();
            var instructor = instructors.FirstOrDefault(i => i.InstructorId == id);
            if (instructor == null) throw new InstructorNotFoundException();
            return instructor;
        }

        public bool EnrollStudentInCourse(int? studentId, int? courseId)
        {
            if (studentId == null && courseId == null) throw new ArgumentNullException();
            var stu = GetStudent(studentId);
            var cou = GetCourse(courseId);
            if(stu.Enroll(cou)) return true;

            return false;
        }

        public IList<Student> ShowAllStudents() => students;

        public IList<Course> ShowAllCourses() => courses;

        public IList<Instructor> ShowAllInstractor() => instructors;


        public bool StudentEnrolledInSpecificCourse(int? studentId, int? courseId)
        {
            if(studentId == null && courseId == null) throw new ArgumentNullException();
            var stu = GetStudent(studentId);
            List<Course> course = stu.Courses.ToList();
            foreach(var courseItem in course)
            {
                if(courseItem.CourseId == courseId) return true;
            }
           return false;
        }


        public string NameOfInstructorByEnrolledCourse(string courseName)
        {
            if(!string.IsNullOrEmpty(courseName))
            {
                var course = courses.FirstOrDefault(c=> c.Instructor.Name == courseName);
                return course.Instructor.Name;
            }
            return string.Empty;
        }


        public static void ShowOperations()
        {
            Console.WriteLine("welcome in Student Management System \nEnter any number of operations\n");
            Console.WriteLine("1. Add Student\n" +
                "2. Add Instructor\n" +
                "3. Add Course\n" +
                "4. Enroll Student in Course\n" +
                "5. Show All Student\n" +
                "6. Show All Students with their courses\n"+
                "7. Show All Course's\n" +
                "8. Show All Instructors\n" +
                "9. Find the student by id or name\n" +
                "10. find the course by id or name\n" +
                "11. Clear The Window\n"+
                "12. Exit\n");
        }
    }
}
