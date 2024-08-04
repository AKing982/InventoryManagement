namespace InventoryManagement.Services;

public interface ServiceBase<T> where T : class
{
    Task<T> GetByIdAsync(int id);
    Task<IEnumerable<T>> GetAllAsync();
    Task<int> AddAsync(T entity);
    Task UpdateAsync(T entity);
    Task DeleteAsync(T entity);
    Task<IEnumerable<T>> SearchAsync(string searchTerm);
    Task<int> GetTotalCountAsync();
}