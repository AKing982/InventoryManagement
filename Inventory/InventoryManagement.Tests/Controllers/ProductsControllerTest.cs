using System.Collections.Generic;
using System.Linq;
using InventoryManagement.Controllers;
using InventoryManagement.Model;
using Moq;
using NUnit.Framework;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using InventoryManagement.DataModel;
using InventoryManagement.Services;
using InventoryManagement.Workbench.Converter;

namespace InventoryManagement.Tests.Controllers;

[TestFixture]
[TestOf(typeof(ProductsController))]
public class ProductsControllerTest
{
    private Mock<IProductService> _productServiceMock;
    private ProductsController _productsController;
    private Product _product;

    [SetUp]
    public void SetUp()
    {
        _productServiceMock = new Mock<IProductService>();
        _productsController = new ProductsController(_productServiceMock.Object);
        _product = new Product
        {
            Id = 1,
            Name = "Test Product",
            SKU = "TP01",
            Description = "This is a test product",
            Price = 10.0m,
            Quantity = 10.0m,
            Category = "Test Category"
        };
    }

    // Testing CreateProduct method
    [Test]
    public async Task CreateProduct_CreatesANewProduct_ReturnsProduct()
    {
        _productServiceMock.Setup(ps => ps.AddAsync(It.IsAny<ProductEntity>())).Returns(Task.FromResult(1));

        var result = await _productsController.CreateProduct(_product);

        Assert.That(result.Value, Is.EqualTo(_product));
    }

    // Testing GetProducts method
    [Test]
    public async Task GetProducts_ReturnsAllProducts_ReturnsProductList()
    {
        var products = new List<Product> { _product };
        var productConverter = new ProductConverter();

        var productEntities = productConverter.ConvertToEntities(products);
        
        _productServiceMock.Setup(ps => ps.GetAllAsync()).Returns(Task.FromResult(productEntities));

        var result = await _productsController.GetProducts();

        Assert.That(result.Value.Count(), Is.EqualTo(1));
        Assert.That(result.Value.First(), Is.EqualTo(_product));
    }

    // Testing UpdateProduct method
    [Test]
    public async Task UpdateProduct_WhenProductExists_UpdatesProduct()
    {
        _productServiceMock.Setup(ps => ps.UpdateAsync(It.IsAny<ProductEntity>())).Returns(Task.CompletedTask);

        var result = await _productsController.UpdateProduct(1, _product);
        
        Assert.That(result, Is.InstanceOf<OkResult>());
    }

    [Test]
    public async Task UpdateProduct_WhenProductIdMismatch_ReturnsBadRequest()
    {
        var result = await _productsController.UpdateProduct(2, _product);

        Assert.That(result, Is.InstanceOf<BadRequestResult>());
    }

    // Testing GetProduct method
    [Test]
    public async Task GetProduct_WhenProductExists_ReturnsProduct()
    {
        ProductEntity productEntity = new ProductEntity();
        _productServiceMock.Setup(ps => ps.GetByIdAsync(It.IsAny<int>())).Returns(Task.FromResult(productEntity));

        var result = await _productsController.GetProduct(1);

        Assert.That(result.Value, Is.EqualTo(_product));
    }

    [Test]
    public async Task GetProduct_WhenProductNotFound_ReturnsNotFoundResult()
    {
        _productServiceMock.Setup(ps => ps.GetByIdAsync(It.IsAny<int>())).Returns(Task.FromResult<ProductEntity>(null));

        var result = await _productsController.GetProduct(1);

        Assert.That(result, Is.InstanceOf<NotFoundResult>());
    }
}