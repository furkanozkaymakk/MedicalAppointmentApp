namespace ServiceLayer.Services.Abstractions
{
    public interface IGenericService<T>
    {
        Task TAddAsync(T entity);
        Task TDeleteAsync(T entity);
        Task<List<T>> TGetAllAsync();
        Task<T> TGetAsync();
        Task<T> TGetByIdAsync(int id);
        Task<T> TUpdateAsync(T entity);
        Task<int> TCountAsync();
        Task<bool> TAnyAsync();

    }
}
