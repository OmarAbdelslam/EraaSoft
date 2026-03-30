using System.Collections;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Test
{

    //[Flags]
    //public enum DaysOfWeek
    //{
    //    None,
    //    Monday,
    //    Tusday,
    //    Wensday,
    //    Thursday,
    //    Friday,
    //    Saturday,
    //    Sunday,
    //    Weekend = Saturday | Sunday,
    //    Workday = Monday | Tusday | Wensday | Thursday | Friday
    //}

    [Flags]
    public enum  MyEnum
    {
        option1 = 1,
        option2 = 2,
        option3 = 4,
        option4 = 8,

        
    }
    public class Program
    {

        public static void TwoStrings(string[]a)
        {
            int[] CountChar = new int[a.Length];
            int i = 0;
            foreach (var c in CountChar)
            {
                Console.Write(a[i].Length + " ");
                i++;
            }
            Console.WriteLine();
            i = 0;
            foreach (var item in CountChar)
            {
                Console.Write(a[i]+" ");
                i++;
            }
        }

        public static void WithoutSlach(string a)
        {
            foreach(var b in a)
            {
                if(b == '\\') break;
                Console.Write(b);
            }
        }

        public static void PrintAlphcabitily(string a,string b)
        {
            int counter = 0;   // 1
            int pointer = 0;   // 1
            int[] arr = new int[2]; // 1   2  = 3
            foreach(var c in a)  //  1  n = 1+n
            {
                if (c < a[pointer+1])   // n
                {
                    counter++;   // 1
                    pointer++;   // 1 
                }
            }
            arr[0] = counter;
            counter = 0;
            pointer = 0;
            foreach (var c in a)
            {
                if (c < a[pointer + 1])
                {
                    counter++;
                    pointer++;
                }
            }
            arr[1] = counter;

            if (arr[0] < arr[1])
            {
                Console.WriteLine(a);
                return;
            }
            Console.WriteLine(b);
        }

        public static void nextmethod(string a,string b)
        {
            int c = 0;
            int counter = 0;
            int counter2 = 0;
            string takeloop = b;
            if (a.Length < b.Length) takeloop = a;
            
            while(c < takeloop.Length)
            {
                if (a[counter] < b[counter])
                {
                    counter++;
                }
                else
                {
                    counter2++;
                }
                c++;
            }
            if(counter > counter2)
            {
                Console.WriteLine(a); return;
            }
            Console.WriteLine(b);

           
        }
        /// <summary>
        /// This is the main entry point of the program. <paramref name="args"/> is an array of command-line arguments passed to the program. The method demonstrates the use of the bitwise OR operator (|) by performing a bitwise OR operation on two integers, `a` and `b`, and printing the result to the console.
        /// <term>
        /// This is a term that describes the main method of the program, which serves as the entry point for execution. It takes an array of strings as arguments, which can be used to pass command-line parameters to the program. The method demonstrates the use of the bitwise OR operator (|) by performing a bitwise OR operation on two integers, `a` and `b`, and printing the result to the console.
        /// </term>
        /// <item>
        /// 
        /// </item>
        /// </summary>
        /// <param name="args"></param>
        
        public static void Main(string[] args)
        {
            //TwoStrings(new string[] { "Hello","World" });
            //WithoutSlach("Hello world in\\World");
            //int AsciiCode = (int)'z';
            //Console.WriteLine(AsciiCode.ToString());
            //nextmethod("Omar", "zzz");



            Console.ReadKey();
        }
    }
}