using InventoryManagement.DataModel;
using InventoryManagement.Repository;

namespace InventoryManagement.Services;

public class UserServiceImpl : IUserService
{
    private IUserRepository _userRepository;

    public UserServiceImpl(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }
    
    public Task<UserEntity> GetByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<UserEntity>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<int> AddAsync(UserEntity entity)
    {
        throw new NotImplementedException();
    }

    public Task UpdateAsync(UserEntity entity)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(UserEntity entity)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<UserEntity>> SearchAsync(string searchTerm)
    {
        throw new NotImplementedException();
    }

    public Task<int> GetTotalCountAsync()
    {
        throw new NotImplementedException();
    }
}