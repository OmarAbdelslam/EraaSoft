namespace ToDoListObject.Data
{
    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public ICollection<Customer> customers { get; set; } = new List<Customer>();

    }
}
