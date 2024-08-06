using InventoryManagement.DataModel;
using InventoryManagement.domain;
using InventoryManagement.Model;
using InventoryManagement.Repository;

namespace InventoryManagement.Services;

public class ProductServiceImpl : IProductService
{
    private readonly IProductRepository _repository;

    public ProductServiceImpl(IProductRepository repository)
    {
        _repository = repository;
    }
    
    public Task<IEnumerable<ProductEntity>> GetByCategoryAsync(string category)
    {
        throw new NotImplementedException();
    }

    public Task<bool> IsSkuUniqueAsync(string sku)
    {
        throw new NotImplementedException();
    }

    public Task UpdateQuantityAsync(int productId, int quantityChange)
    {
        throw new NotImplementedException();
    }

    public Task DeleteProduct(int id)
    {
        throw new NotImplementedException();
    }

    public Task<ProductEntity> GetByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<ProductEntity>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<int> AddAsync(ProductEntity entity)
    {
        throw new NotImplementedException();
    }

    public Task UpdateAsync(ProductEntity entity)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(ProductEntity entity)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<ProductEntity>> SearchAsync(string searchTerm)
    {
        throw new NotImplementedException();
    }

    public Task<int> GetTotalCountAsync()
    {
        throw new NotImplementedException();
    }
}