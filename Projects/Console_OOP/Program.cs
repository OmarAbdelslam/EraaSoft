namespace Console_OOP
{

    public abstract class Employess
    {
        protected Employess()
        {
            Console.WriteLine("An Employee Class Object");
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public int Adg { get; set; }
        public DateTime HigerDate { get; set; }


        public virtual void Hello()
        {
            Console.WriteLine("Hello Employees");
        }
    }

    public class Accountant : Employess
    {
        public Accountant()
        {
            Console.WriteLine("An Accountant Class Object");
        }

        public override void Hello()
        {
            Console.WriteLine("Hello Accountant");
        }

        
    }

    public class Enginner : Employess 
    {
        public Enginner()
        {
            Console.WriteLine("An Enginner Class Object");
        }

        public override void Hello()
        {
            Console.WriteLine("Hello Enginner");
        }
    }

    public class Techer : Employess
    {
        public Techer()
        {
            Console.WriteLine("An Techer Class Object");
        }

        public new void Hello()
        {
            Console.WriteLine("Hello Techer");
        }
    }

    internal class Program
    {

        static void Main(string[] args)
        {
            Employess employess = new Enginner();
            employess.Hello();
            Console.ReadKey();
        }
    }
}
