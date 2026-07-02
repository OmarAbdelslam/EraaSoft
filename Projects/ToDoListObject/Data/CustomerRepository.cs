using ToDoListObject.Contracts;

namespace ToDoListObject.Data
{
    public class CustomerRepository : IRepository<Customer>
    {

        private readonly DBWork _dBWork;
        public CustomerRepository(DBWork dBWork)
        {
            _dBWork = dBWork;
        }

        public void Add(Customer entity)
        {
            _dBWork._customers.Add(entity);
        }

        public void AddRange(IList<Customer> entities)
        {
            foreach (var e in entities) _dBWork._customers.Add(e);
        }

        public void Delete(Customer entity)
        {
            _dBWork._customers.Remove(entity);
        }

        public void DeleteRange(IList<Customer> entities)
        {
            foreach (var e in entities) _dBWork._customers.Remove(e);
        }

        public Customer Select(Customer entity)
        {
            if (entity is null) throw new NullReferenceException();
            _dBWork._customers.Where(c=> c.ID == entity.ID || )
        }

        public IList<Customer> SelectMany(Customer entities)
        {
            throw new NotImplementedException();
        }

        public void Update(Customer entity)
        {
            throw new NotImplementedException();
        }

        public void UpdateRange(Customer entities)
        {
            throw new NotImplementedException();
        }
    }
}
