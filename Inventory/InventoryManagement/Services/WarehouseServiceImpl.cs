using InventoryManagement.DataModel;
using InventoryManagement.Repository;

namespace InventoryManagement.Services;

public class WarehouseServiceImpl : IWarehouseService
{
    private IWarehouseRepository _warehouseRepository;

    public WarehouseServiceImpl(IWarehouseRepository warehouseRepository)
    {
        _warehouseRepository = warehouseRepository;
    }
    
    public Task<WarehouseEntity> GetByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<WarehouseEntity>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<int> AddAsync(WarehouseEntity entity)
    {
        throw new NotImplementedException();
    }

    public Task UpdateAsync(WarehouseEntity entity)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(WarehouseEntity entity)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<WarehouseEntity>> SearchAsync(string searchTerm)
    {
        throw new NotImplementedException();
    }

    public Task<int> GetTotalCountAsync()
    {
        throw new NotImplementedException();
    }
}