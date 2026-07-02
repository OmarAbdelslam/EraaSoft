namespace ToDoListObject.Contracts
{
    public interface IRepository<TEntity>
    {
        void Add(TEntity entity);

        void AddRange(IList<TEntity> entities);

        TEntity Select(TEntity entity);

        IList<TEntity> SelectMany(TEntity entities);

        void Update(TEntity entity);

        void UpdateRange(TEntity entities);

        void Delete(TEntity entity);

        void DeleteRange(IList<TEntity> entities);
    }
}
