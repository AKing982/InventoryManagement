using InventoryManagement.DataModel;
using InventoryManagement.Model;
using InventoryManagement.Repository;

namespace InventoryManagement.Services;

public class IOrderServiceImpl : IOrderService
{
    private IOrderRepository _orderRepository;

    public IOrderServiceImpl(IOrderRepository orderRepository)
    {
        _orderRepository = orderRepository;
    }
    
    public Task<IEnumerable<OrderEntity>> GetByOrderIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<OrderEntity>> GetByOrderNumberAsync(string orderNumber)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<OrderEntity>> GetByOrderDateAsync(DateTime orderDate)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<OrderEntity>> GetByOrderDateBetweenStartDateAndEndDate(DateTime startDate, DateTime endDate)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<OrderEntity>> GetByOrderStatus(OrderStatus status)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<OrderEntity>> GetByCustomerId(int customerId)
    {
        throw new NotImplementedException();
    }

    public Task<OrderEntity> GetByOrderIdAndAmount(int id, decimal amount)
    {
        throw new NotImplementedException();
    }

    public Task<OrderEntity> GetByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<OrderEntity>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<int> AddAsync(OrderEntity entity)
    {
        throw new NotImplementedException();
    }

    public Task UpdateAsync(OrderEntity entity)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(OrderEntity entity)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<OrderEntity>> SearchAsync(string searchTerm)
    {
        throw new NotImplementedException();
    }

    public Task<int> GetTotalCountAsync()
    {
        throw new NotImplementedException();
    }
}