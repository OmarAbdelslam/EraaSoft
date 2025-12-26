namespace Test
{

    public class Program
    {
        private int[] array = { 1, 2, 3, 4, 5 };
        public int this[int a] => array[a];
        public static void Main(string[] args)
        {
            Program program = new Program();
            Console.WriteLine( program[0]);
            Console.ReadKey();
        }
    }
}
