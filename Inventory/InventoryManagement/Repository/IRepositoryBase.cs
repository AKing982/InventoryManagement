namespace InventoryManagement.Repository;

public interface IRepositoryBase<T> where T : class
{
    Task<T> GetByIdAsync(int id);
    Task<IEnumerable<T>> GetAllAsync();
    Task<int> AddAsync(T product);
    Task UpdateAsync(T product);
    Task DeleteAsync(int id);
}