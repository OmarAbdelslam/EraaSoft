using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_s_Contant
{
    public class StorListOperations
    {
        public List<int> Numbers { get;private set; }

        public StorListOperations(List<int> numbers) 
        {
            Numbers = numbers; 
        }

        public void print()
        {
            if (Numbers is not null)
            {
                Console.Write("[ ");
                Console.Write(String.Join(",",Numbers).ToString());
                Console.WriteLine(" ]");
            }
            else
                Console.WriteLine("[] - the list is empty");
        }


        public void Add(int number)
        {
            Numbers.Add(number);
            Console.WriteLine($"{number} Added");
        }

        public void Average()
        {
            if (Numbers != null)
            {
                Console.WriteLine(Numbers.Average());
                return;
            }
            Console.WriteLine("The list is empty, fill it and try again\n");
        }

        public void smallest()
        {
            if (Numbers != null)
            {
                Console.WriteLine(Numbers.Min());
                return;
            }
            Console.WriteLine("The list is empty, fill it and try again\n");
        }

        public void select(int number)
        {
            int num = Numbers.IndexOf(number);
            Console.WriteLine(num);
        }

        public void remove(int number)
        {
            bool Try =Numbers.Remove(number);
            if (Try is true) Console.WriteLine("Removed");
            else Console.WriteLine("The number isn't found");
        }

        public void largest()
        {
            if (Numbers != null)
            {
                Console.WriteLine(Numbers.Max());
                return;
            }
            Console.WriteLine("The list is empty, fill it and try again\n");
        }

        public void Sort()
        {
            Numbers.Sort();
        }

        public void Any()
        {
            Numbers.Any();
        }
    }
}
