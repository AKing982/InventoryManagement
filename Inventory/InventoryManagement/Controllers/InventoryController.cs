using InventoryManagement.DataModel;
using InventoryManagement.domain;
using InventoryManagement.Services;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace InventoryManagement.Controllers;

[ApiController]
[Route("/api/inventory")]
public class InventoryController : Controller
{
    private IInventoryService _inventoryService;

    public InventoryController(IInventoryService inventoryService)
    {
        _inventoryService = inventoryService;
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<InventoryEntity>> GetByIdAsync(int id)
    {
        return null;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<InventoryEntity>>> GetInventory()
    {
        var inventory = _inventoryService.GetAllAsync();
        return Ok(inventory);
    }
    
    [HttpPost]
    public async Task<ActionResult<int>> AddInventory([FromBody] InventoryDTO inventoryEntity)
    {
        return null;
    }
}