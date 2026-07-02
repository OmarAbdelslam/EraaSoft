namespace ToDoListObject.Data
{
    public class DBWork
    {
        public ICollection<Customer> _customers;
        public ICollection<Employee> _employees;

        public DBWork()
        {
            _customers = new List<Customer>();
            _employees = new List<Employee>();
        }
    }
}
