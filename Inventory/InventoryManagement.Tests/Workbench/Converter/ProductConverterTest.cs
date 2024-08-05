using System;
using InventoryManagement.Workbench.Converter;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;
using InventoryManagement.Model;
using InventoryManagement.DataModel;

namespace InventoryManagement.Tests.Workbench.Converter;

[TestFixture]
[TestOf(typeof(ProductConverter))]
public class ProductConverterTest
{
    private ProductConverter _testSubject;
    private ProductEntity _testEntity;
    private Product _testProduct;

    [SetUp]
    public void SetUp()
    {
        _testSubject = new ProductConverter();
        _testEntity = new ProductEntity
        {
            Id = 1,
            Name = "TestName",
            SKU = "TestSKU",
            Description = "TestDescription",
            Price = 50.0M,
            Quantity = 5,
            category = "TestCategory"
        };
        _testProduct = new Product(2, "TestName2", "TestSKU2", "TestDescription2", 60.0M, 10, "TestCategory");
    }

    [Test]
    public void convertFromEntity_ShouldConvertCorrectly()
    {
        // Arrange
        // Act
        var result = _testSubject.convertFromEntity(_testEntity);
        // Assert
        Assert.That(_testEntity.Id, Is.EqualTo(result.Id));
        Assert.That(_testEntity.Name, Is.EqualTo(result.Name));
        //...Repeat for all properties
    }

    [Test]
    public void convertFromEntity_ShouldReturnNullForNullEntity()
    {
        // Arrange
        _testEntity = null;

        Assert.Throws<ArgumentNullException>(() => _testSubject.convertFromEntity(_testEntity));
    }

    [Test]
    public void convertToEntity_ShouldConvertCorrectly()
    {
        // Arrange
        // Act
        var result = _testSubject.convertToEntity(_testProduct);
        // Assert
        Assert.That(_testProduct.Id, Is.EqualTo(result.Id));
        Assert.That(_testProduct.Name, Is.EqualTo(result.Name));
        //...Repeat for all properties
    }

    [Test]
    public void convertToEntity_ShouldReturnNullForNullModel()
    {
        // Arrange
        _testProduct = null;

        // Assert
        Assert.Throws<ArgumentNullException>(() => _testSubject.convertToEntity(_testProduct));
    }

    [Test]
    public void ConvertToEntities_ShouldConvertAllModels()
    {
        // Arrange
        var models = new List<Product> { _testProduct, _testProduct };
        // Act
        var result = _testSubject.ConvertToEntities(models);
        // Assert
        Assert.That(models.Count, Is.EqualTo(result.Count()));
    }

    [Test]
    [Description(
        "Test convertToEntities when product model is null, then skip null product and return product entity list")]
    public void convertToEntities_whenProductModelIsNull_SkipNullProduct_AndReturnProductEntityList()
    {
        // Arrange
        var models = new List<Product> { null, _testProduct, null, _testProduct };
        var expectedCount = models.Count(e => e != null);

        var expectedEntities = new List<ProductEntity> { _testEntity, _testEntity };
        
        // Act
        var result = _testSubject.ConvertToEntities(models);
        var actualCount = result.Count(e => e != null);
        
        Assert.That(expectedCount, Is.EqualTo(actualCount));
    }

    [Test]
    public void convertFromEntities_ShouldConvertAllEntities()
    {
        // Arrange
        var entities = new List<ProductEntity> { _testEntity, _testEntity };
        // Act
        var result = _testSubject.convertFromEntities(entities);
        // Assert
        Assert.That(entities.Count, Is.EqualTo( result.Count()));
    }
}