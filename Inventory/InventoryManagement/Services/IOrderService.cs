using InventoryManagement.DataModel;
using InventoryManagement.Model;

namespace InventoryManagement.Services;

public interface IOrderService : ServiceBase<OrderEntity>
{
    Task<IEnumerable<OrderEntity>> GetByOrderIdAsync(int id);
    Task<IEnumerable<OrderEntity>> GetByOrderNumberAsync(string orderNumber);
    Task<IEnumerable<OrderEntity>> GetByOrderDateAsync(DateTime orderDate);
    Task<IEnumerable<OrderEntity>> GetByOrderDateBetweenStartDateAndEndDate(DateTime startDate, DateTime endDate);
    Task<IEnumerable<OrderEntity>> GetByOrderStatus(OrderStatus status);
    Task<IEnumerable<OrderEntity>> GetByCustomerId(int customerId);
    Task<OrderEntity> GetByOrderIdAndAmount(int id, decimal amount);
    
}