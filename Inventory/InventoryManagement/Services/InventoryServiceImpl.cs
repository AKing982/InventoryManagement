using InventoryManagement.Model;
using InventoryManagement.Repository;

namespace InventoryManagement.Services;

public class InventoryServiceImpl : IInventoryService
{
    private IInventoryRepository _inventoryRepository;

    public InventoryServiceImpl(IInventoryRepository inventoryRepository)
    {
        _inventoryRepository = inventoryRepository;
    }
    
    public Task<Inventory> GetByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Inventory>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<int> AddAsync(Inventory entity)
    {
        throw new NotImplementedException();
    }

    public Task UpdateAsync(Inventory entity)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(Inventory entity)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Inventory>> SearchAsync(string searchTerm)
    {
        throw new NotImplementedException();
    }

    public Task<int> GetTotalCountAsync()
    {
        throw new NotImplementedException();
    }
}