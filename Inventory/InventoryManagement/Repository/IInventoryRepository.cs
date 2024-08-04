using InventoryManagement.DataModel;
using InventoryManagement.Model;

namespace InventoryManagement.Repository;

public interface IInventoryRepository : IRepositoryBase<InventoryEntity>
{
    Task<InventoryEntity> GetByIdAsync(int id);

    Task<IEnumerable<InventoryEntity>> GetAllAsync();
    
    Task<int> AddAsync(InventoryEntity inventory);

    Task UpdateAsync(InventoryEntity inventoryEntity);

    Task DeleteAsync(int d);
}