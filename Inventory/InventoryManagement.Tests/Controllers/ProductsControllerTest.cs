using InventoryManagement.Controllers;
using InventoryManagement.Model;
using InventoryManagement.Services;
using Microsoft.AspNetCore.Mvc;
using Moq;
using NUnit.Framework;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace InventoryManagement.Tests.Controllers;

[TestFixture]
public class ProductsControllerTest
{
    private Mock<IProductService> _productServiceMock;
    private ProductsController _productsController;

    [SetUp]
    public void Setup()
    {
        _productServiceMock = new Mock<IProductService>();
        _productsController = new ProductsController(_productServiceMock.Object);
    }

    [Test]
    public async Task CreateProduct_ShouldReturnCreatedAtActionResult()
    {
        var product = new Product(1, "Test", "TestSKU", "Description", 10, 2, "Category");
        _productServiceMock.Setup(service => service.AddAsync(product)).Returns(Task.FromResult(1));

        var result = await _productsController.CreateProduct(product);

        Assert.That(result.Result, Is.InstanceOf<CreatedAtActionResult>());
    }

    [Test]
    public async Task GetProducts_ShouldReturnOkObjectResult()
    {
        _productServiceMock.Setup(service => service.GetAllAsync()).Returns(
            Task.FromResult<IEnumerable<Product>>(new Product[]
                { new Product(1, "Test", "TestSKU", "Description", 10, 2, "Category") }));

        var result = await _productsController.GetProducts();

        Assert.That(result.Result, Is.InstanceOf<OkObjectResult>());
    }

    [Test]
    public async Task UpdateProduct_ShouldReturnNoContentResult()
    {
        var product = new Product(1, "Test", "TestSKU", "Description", 10, 2, "Category");
        _productServiceMock.Setup(service => service.UpdateAsync(product)).Returns(Task.CompletedTask);

        var result = await _productsController.UpdateProduct(1, product);

        
        Assert.That(result, Is.InstanceOf<NoContentResult>());
        _productServiceMock.Verify(service => service.UpdateAsync(product), Times.Once);
        
    }

    [Test]
    public async Task GetProduct_ShouldReturnOkObjectResult()
    {
        var product = new Product(1, "Test", "TestSKU", "Description", 10, 2, "Category");
        _productServiceMock.Setup(service => service.GetByIdAsync(1)).Returns(Task.FromResult(product));

        var result = await _productsController.GetProduct(1);

        // Assert
        Assert.That(result.Result, Is.InstanceOf<OkObjectResult>());
        var okResult = result.Result as OkObjectResult;
        Assert.That(okResult, Is.Not.Null);
        Assert.That(okResult.Value, Is.EqualTo(product));
    }

    [Test]
    public async Task GetProduct_ShouldReturnNotFoundResult_WhenProductDoesNotExist()
    {
        _productServiceMock.Setup(service => service.GetByIdAsync(1)).Returns(Task.FromResult<Product>(null));

        var result = await _productsController.GetProduct(1);

        Assert.That(result.Result, Is.InstanceOf<NotFoundResult>());
    }
}