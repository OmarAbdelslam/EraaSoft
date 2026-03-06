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

        public static void Fibonacci(int count)
        {
            int a = 1;

            int[] arr = new int[count];
            int c = 1;
            for(c = 1;c <= count;c++)
            {
                if(arr.Count() > c && (c != 0 && arr[c] != 1))
                {
                    arr[c] = arr[c];
                    
                }
                else
                {
                    arr[c] = arr[c] + a;
                    ++a;
                }
            }
            foreach(int i in arr)
            {
                Console.WriteLine(i);
            }
        }

        static void Main(string[] args)
        {
            Fibonacci(7);
        }
    }
}
