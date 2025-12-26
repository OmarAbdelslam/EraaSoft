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
        public IList<Student> students { get; set; }

        public IList<Course> courses { get; set; }

        public IList<Instructor> instructors { get; set; }


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

        public Student GetStudent(int? id)
        {
            if(id != null) throw new ArgumentNullException();
            var student = students.FirstOrDefault(s=> s.StudentId == id);
            if(student == null) throw new StudentNotFoundException();
            return student;
        }

        public Course GetCourse(int? id)
        {
            if (id != null) throw new ArgumentNullException();
            var course = courses.FirstOrDefault(c => c.CourseId == id);
            if (course == null) throw new CourseNotFoundException();
            return course;
        }

        public Instructor GetInstructor(int? id)
        {
            if (id != null) throw new ArgumentNullException();
            var instructor = instructors.FirstOrDefault(i => i.InstructorId == id);
            if (instructor == null) throw new InstructorNotFoundException();
            return instructor;
        }

        public bool EnrollStudentInCourse(int? studentId, int? courseId)
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

    }
}
