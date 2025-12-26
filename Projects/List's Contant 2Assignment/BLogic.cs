using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_s_Contant
{
    public class BLogic
    {
        public void Choose()
        {
            Console.WriteLine("P - Print numbers");
            Console.WriteLine("A - Add a number");
            Console.WriteLine("M - Display mean of the numbers");
            Console.WriteLine("S - Display the smallest number");
            Console.WriteLine("Se - Enter your number that is you want to know index it");
            Console.WriteLine("R - Remove the number which you will enter it");
            Console.WriteLine("L - Display the largest number");
            Console.WriteLine("C - Clear the window");
            Console.WriteLine("Q - Quit");
        }

        public void Business()
        {
            try
            {
                StorListOperations listOperations = new StorListOperations([5, 18, 2, 25, 99, 1]);
                Choose();
            next:
                string commend = Console.ReadLine().ToString().ToUpper() ?? "There aren't any commend";

                if (commend == "P") listOperations.print();
                else if (commend == "A")
                {
                    Console.WriteLine("Enter your number");
                    int number = int.Parse(Console.ReadLine());
                    listOperations.Add(number);
                }
                else if (commend == "M") listOperations.Average();
                else if (commend == "S") listOperations.smallest();
                else if (commend == "SE")
                {
                    Console.WriteLine("Enter your number");
                    int num = int.Parse(Console.ReadLine());
                    listOperations.select(num);
                }
                else if (commend == "R")
                {
                    Console.WriteLine("Enter your number");
                    int num = int.Parse(Console.ReadLine());
                    listOperations.remove(num);
                }
                else if (commend == "L") listOperations.largest();
                else if (commend == "C") { Console.Clear(); Choose(); }
                else if (commend == "Q")
                {
                    Console.WriteLine("Closing..."); return;
                }
                Console.WriteLine("Please, Enter another commend");
                goto next;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
