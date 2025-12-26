using ManagementSystemLibrary.Entities;

namespace ManagementSystemLibrary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();
            library.books = new List<Book>()
            {
                new Book("Computer Scinse","Ahmed Bahget","123",true),
                new Book("ICDL","Samira Ahmed","321",false)
            };

            
            Console.WriteLine(library.Returnbook("ICDL"));
            Console.WriteLine(library.GetBook("ICDL"));
            Console.WriteLine(library.Isborrow("Computer Scinse"));
            Console.WriteLine(library.GetBook("Computer Scinse"));

            Console.ReadKey();
        }
    }
}
