using InventoryManagement.DataModel;
using InventoryManagement.Repository;

namespace InventoryManagement.Services;

public class ContactsServiceImpl : IContactsService
{
    private IContactsRepository _contactsRepository;

    public ContactsServiceImpl(IContactsRepository contactsRepository)
    {
        _contactsRepository = contactsRepository;
    }
    
    public Task<ContactEntity> GetByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<ContactEntity>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<int> AddAsync(ContactEntity entity)
    {
        throw new NotImplementedException();
    }

    public Task UpdateAsync(ContactEntity entity)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(ContactEntity entity)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<ContactEntity>> SearchAsync(string searchTerm)
    {
        throw new NotImplementedException();
    }

    public Task<int> GetTotalCountAsync()
    {
        throw new NotImplementedException();
    }
}