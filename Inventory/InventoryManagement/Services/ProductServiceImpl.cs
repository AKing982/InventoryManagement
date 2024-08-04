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
    
    public Task<IEnumerable<Product>> GetByCategoryAsync(string category)
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

    public Task<Product> GetByIdAsync(int id)
    {
        return _repository.GetByIdAsync(id);
    }

    public Task<IEnumerable<Product>> GetAllAsync()
    {
        return _repository.GetAllAsync();
    }

    public Task<int> AddAsync(Product entity)
    {
        return _repository.AddAsync(entity);
    }

    public Task<int> AddAsync(ProductDTO entity)
    {
        throw new NotImplementedException();
    }

    public Task UpdateAsync(Product entity)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(Product entity)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Product>> SearchAsync(string searchTerm)
    {
        throw new NotImplementedException();
    }

    public Task<int> GetTotalCountAsync()
    {
        throw new NotImplementedException();
    }
}