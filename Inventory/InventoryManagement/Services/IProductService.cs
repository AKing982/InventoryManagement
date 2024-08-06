using InventoryManagement.DataModel;
using InventoryManagement.domain;
using InventoryManagement.Model;

namespace InventoryManagement.Services;

public interface IProductService : ServiceBase<ProductEntity>
{
    Task<IEnumerable<ProductEntity>> GetByCategoryAsync(string category);
    Task<bool> IsSkuUniqueAsync(string sku);
    Task UpdateQuantityAsync(int productId, int quantityChange);

    Task DeleteProduct(int id);
}