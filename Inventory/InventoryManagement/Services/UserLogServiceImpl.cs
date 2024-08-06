using InventoryManagement.DataModel;
using InventoryManagement.Repository;

namespace InventoryManagement.Services;

public class UserLogServiceImpl : IUserLogService
{
    private IUserLogRepository _userLogRepository;
    
    public UserLogServiceImpl(IUserLogRepository userLogRepository)
    {
        _userLogRepository = userLogRepository;
    }
    
    public Task<UserLogEntity> GetByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<UserLogEntity>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<int> AddAsync(UserLogEntity entity)
    {
        throw new NotImplementedException();
    }

    public Task UpdateAsync(UserLogEntity entity)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(UserLogEntity entity)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<UserLogEntity>> SearchAsync(string searchTerm)
    {
        throw new NotImplementedException();
    }

    public Task<int> GetTotalCountAsync()
    {
        throw new NotImplementedException();
    }
}