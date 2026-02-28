namespace DSA
{

    public class Node
    {

        public Node _next;
        public string _data;
        public Node(Node next,string data) 
        {
            _data = data;
            _next = next;
        }

    }

    public class LinkedList
    {
        public Node Head { get; set; } = default;
        private Node currentNodeNext;

        public void Add(Node node)
        {
            if (Head == null)
            {
                Head = node;
                return;
            }

            currentNodeNext = Head;
            while (currentNodeNext._next != null)
            {
                currentNodeNext = currentNodeNext._next;
            }

            currentNodeNext._next = node;
        }

        public void ShowData()
        {
            Node current = Head;

            if (current == null)
            {
                Console.WriteLine("There is no data");
                return;
            }

            while (current != null)
            {
                Console.WriteLine(current._data);
                current = current._next;
            }
        }
    }
    internal class Program
    {

        static void Array(int[] arr)
        {
            int[]distinctarray = new int[arr.Length];
            int count = 0;
            foreach(int a in arr)
            {

            }
        }
        static void Main(string[] args)
        {
            Array(new[] { 4,5,6,8,4,2,8} );
        }
    }
}
