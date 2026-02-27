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
        static void Main(string[] args)
        {
            LinkedList linkedList = new LinkedList();
            linkedList.Add(new Node(null, "Omar"));
            linkedList.Add(new Node(null, "Ahmed"));
            linkedList.Add(new Node(null, "Mohammed"));

            linkedList.ShowData();
        }
    }
}
