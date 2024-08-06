using InventoryManagement.DataModel;

namespace InventoryManagement.Repository;

public interface IOrderRepository : IRepositoryBase<OrderEntity>
{
    Task<OrderEntity> GetByIdAsync(int id);
    Task<IEnumerable<OrderEntity>> GetAllAsync();
    Task<int> AddAsync(OrderEntity order);
    Task UpdateAsync(OrderEntity orderEntity);
    Task DeleteAsync(int id);
}