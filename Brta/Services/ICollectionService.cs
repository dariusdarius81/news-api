namespace NewsApi.Services
{
    public interface ICollectionService<T> where T : new()
    {
        bool Create(T model);

        bool Delete(Guid id);

        T Get(Guid id);

        List<T> GetAll();

        bool Update(Guid id, T model);
    }
}