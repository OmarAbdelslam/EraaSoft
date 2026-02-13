namespace Test
{
    public class Program
    {

        public static string[] arrstring()
        {
            return new string[] { "omar", "Ahmed", "Ali", "Hossam", "Mohammed" };
        }
       

        public static void mm(string[] arr)
        {
            string text;
        next:
            for (int a = 0; a < arr.Length -1; a++)
            {
                if (arr[a].Length < arr[a +1].Length)
                {
                    text = arr[a];
                    arr[a] = arr[a + 1];
                    arr[a + 1] = text;
                    goto next;
                }
            }
            foreach(var a in arr)
            {
                Console.WriteLine(a);
            }
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Starting....");
            mm(arrstring());
            Console.ReadKey();
        }
    }
}
