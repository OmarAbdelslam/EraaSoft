using Entities;
using Entities.DBWork;

namespace StudentManagementSystem
{
    internal static class Program
    {
        /* I didn't use the constractor because it dosen't static CTOR and the class 
         * doesn't static
         * 1- the static member generated before anything as normal 
         * 2-  if I used the CTRO to generate object after that I'll ues it in Main method
         * , it will throw an exception 
        */
        private static readonly BLogic bLogic;
        static Program()
        {
            bLogic = new BLogic();
        }
        static void Main(string[] args)
        {
        
            AppDBcontext.ShowOperations();
        next:
            Console.WriteLine("\nEnter Another Method");
            try
            {
                string read = Console.ReadLine();
                if (read == "1")
                {
                    Console.WriteLine(bLogic.AddStudent());
                }
                if (read == "2")
                {
                    Console.WriteLine(bLogic.AddInstractor());
                }
                if (read == "3")
                {
                    Console.WriteLine(bLogic.AddCourse());
                }
                if (read == "4")
                {
                    bLogic.EnrollStudentinSpecifiCourse();
                }
                if (read == "5")
                {
                    bLogic.ShowAllStudents();
                }
                if (read == "6")
                {
                    bLogic.ShowAllStudentsWithTheirCourses();
                }
                if (read == "7")
                {
                    bLogic.ShowAllCourses();
                }
                if (read == "8")
                {
                    bLogic.ShowAllInstractor();
                }
                if (read == "9")
                {
                    bLogic.GetStudent();
                }
                if (read == "10")
                {
                    bLogic.GetCourse();
                }
                if (read == "11")
                {
                    Console.Clear();
                    AppDBcontext.ShowOperations();
                    goto next;
                }
                if (read == "12")
                {
                    Environment.Exit(0);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            goto next;
            Console.ReadKey();
        }
    }
}
