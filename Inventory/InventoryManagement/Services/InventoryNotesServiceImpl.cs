using InventoryManagement.DataModel;
using InventoryManagement.Repository;

namespace InventoryManagement.Services;

public class InventoryNotesServiceImpl : IInventoryNotesService
{
    private IInventoryNotesRepository _inventoryNotesRepository;

    public InventoryNotesServiceImpl(IInventoryNotesRepository inventoryNotesRepository)
    {
        _inventoryNotesRepository = inventoryNotesRepository;
    }
    
    public Task<InventoryNotesEntity> GetByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<InventoryNotesEntity>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<int> AddAsync(InventoryNotesEntity entity)
    {
        throw new NotImplementedException();
    }

    public Task UpdateAsync(InventoryNotesEntity entity)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(InventoryNotesEntity entity)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<InventoryNotesEntity>> SearchAsync(string searchTerm)
    {
        throw new NotImplementedException();
    }

    public Task<int> GetTotalCountAsync()
    {
        throw new NotImplementedException();
    }
}