using InventoryManagement.DataModel;
using InventoryManagement.Model;
    
namespace InventoryManagement.Repository;

public interface IProductRepository : IRepositoryBase<ProductEntity>
{
    Task<ProductEntity> GetByIdAsync(int id);
    Task<IEnumerable<ProductEntity>> GetAllAsync();
    Task<int> AddAsync(ProductEntity product);
    Task UpdateAsync(ProductEntity product);
    Task DeleteAsync(int id);
}