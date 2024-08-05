using InventoryManagement.DataModel;
using InventoryManagement.Model;

namespace InventoryManagement.Workbench.Converter;

public class ProductConverter : EntityConverter<ProductEntity, Product>
{
    public Product convertFromEntity(ProductEntity entity)
    {
        if (entity == null)
        {
            throw new ArgumentNullException(nameof(entity));
        }

        var product = new Product
        {
            Id = entity.Id,
            Name = entity.Name,
            SKU = entity.SKU,
            Description = entity.Description,
            Price = entity.Price,
            Quantity = entity.Quantity,
            Category = entity.category
        };
        
        return product;
    }

    public ProductEntity convertToEntity(Product model)
    {
        if (model == null)
        {
            throw new ArgumentNullException(nameof(model));
        }

        var productEntity = new ProductEntity
        {
            Id = model.Id,
            Name = model.Name,
            SKU = model.SKU,
            Description = model.Description,
            Price = model.Price,
            Quantity = model.Quantity,
            category = model.Category
        };

        return productEntity;
    }

    public IEnumerable<ProductEntity> ConvertToEntities(IEnumerable<Product> models)
    {
        List<ProductEntity> entities = new List<ProductEntity>();
        foreach (var product in models)
        {
            if (product != null)
            {
                ProductEntity productEntity = convertToEntity(product);
                entities.Add(productEntity);
            }
        }
        return entities;
    }

    public IEnumerable<Product> convertFromEntities(IEnumerable<ProductEntity> entities)
    {
        List<Product> products = new List<Product>();
        foreach(var entity in entities)
        {
            if (entity != null)
            {
                Product product = convertFromEntity(entity);
                products.Add(product); 
            }
        }
        return products;
    }
}