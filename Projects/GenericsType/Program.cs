namespace GenericsType
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool Result1 = ClsCalculator.AreEqual<int>(5, 5);
            bool Result2 = ClsCalculator.AreEqual<string>("Omar", "Ahmed");
            bool Result3 = ClsCalculator.AreEqual<double>(10.5, 0.5);

            Console.WriteLine(Result1+"\n"+Result2+"\n"+Result3);
            Console.ReadKey();
        }
    }
}
