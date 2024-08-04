using System.Collections.Specialized;
using InventoryManagement.domain;
using InventoryManagement.Model;
using InventoryManagement.Services;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace InventoryManagement.Controllers;

[ApiController]
[Route("api/products")]
public class ProductsController : Controller
{
    private readonly IProductService _productService;

    public ProductsController(IProductService productService)
    {
        _productService = productService;
    }

    [HttpPost]
    public async Task<ActionResult<Product>> CreateProduct(Product product)
    {
        var id = await _productService.AddAsync(product);
        return CreatedAtAction(nameof(GetProduct), new { id = id }, product);
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Product>>> GetProducts()
    {
        var products = await _productService.GetAllAsync();
        return Ok(products);
    }

    [HttpPut("id")]
    public async Task<IActionResult> UpdateProduct(int id, Product product)
    {
        int productId = product.Id;
        if (id != product.Id)
        {
            return BadRequest();
        }

        await _productService.UpdateAsync(product);
        return NoContent();
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Product>> GetProduct(int id)
    {
        var product = await _productService.GetByIdAsync(id);
        if (product == null)
        {
            return NotFound();
        }

        return Ok(product);
    }
    
    
}