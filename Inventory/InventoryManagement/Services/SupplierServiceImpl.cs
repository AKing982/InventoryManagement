using InventoryManagement.DataModel;
using InventoryManagement.Repository;

namespace InventoryManagement.Services;

public class SupplierServiceImpl : ISupplierService
{
    private ISupplierRepository _supplierRepository;

    public SupplierServiceImpl(ISupplierRepository supplierRepository)
    {
        _supplierRepository = supplierRepository;
    }
    
    public Task<SupplierEntity> GetByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<SupplierEntity>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<int> AddAsync(SupplierEntity entity)
    {
        throw new NotImplementedException();
    }

    public Task UpdateAsync(SupplierEntity entity)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(SupplierEntity entity)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<SupplierEntity>> SearchAsync(string searchTerm)
    {
        throw new NotImplementedException();
    }

    public Task<int> GetTotalCountAsync()
    {
        throw new NotImplementedException();
    }
}