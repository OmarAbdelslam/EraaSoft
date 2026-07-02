namespace CampusOs.IRepositoryContracts
{
    public interface IRepository<T> where T : class
    {
        Task<bool> AddAsync(T obj);

        Task<T> GetAsync(T obj);

        Task<bool> UpdateAsync(T obj);

        Task<bool> DeleteAsync(T obj);
    }
}
