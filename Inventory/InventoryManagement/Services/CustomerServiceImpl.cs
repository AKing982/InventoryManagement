using InventoryManagement.DataModel;
using InventoryManagement.Repository;

namespace InventoryManagement.Services;

public class CustomerServiceImpl : ICustomerService
{
    private ICustomerRepository _customerRepository;

    public CustomerServiceImpl(ICustomerRepository customerRepository)
    {
        _customerRepository = customerRepository;
    }
    
    public Task<CustomerEntity> GetByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<CustomerEntity>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<int> AddAsync(CustomerEntity entity)
    {
        throw new NotImplementedException();
    }

    public Task UpdateAsync(CustomerEntity entity)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(CustomerEntity entity)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<CustomerEntity>> SearchAsync(string searchTerm)
    {
        throw new NotImplementedException();
    }

    public Task<int> GetTotalCountAsync()
    {
        throw new NotImplementedException();
    }
}