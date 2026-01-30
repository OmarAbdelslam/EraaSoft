namespace SoultionSessionDec27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EBook eBook = new EBook();
            PhysicalBook physicalBook = new PhysicalBook();
            Console.WriteLine(eBook);
            Console.WriteLine(physicalBook);
            Console.ReadLine();
        }
    }
}
