using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using HardwareStoreApi.Data;
using HardwareStoreApi.Model;

namespace HardwareStoreApi.Controllers;

[Route ("api/[controller]")]
[ApiController]

public class InventoryItemsController : ControllerBase
{
    private readonly AppDbContext _context;
    public InventoryItemsController (AppDbContext context) {_context = context;}

    [HttpGet]
    public async Task <ActionResult<IEnumerable<InventoryItem>>>GetInventoryItems(
    string? category,
    string? sortBy,
    int page = 1,
    int pageSize = 10)
    {
        IQueryable <InventoryItem> query = _context.InventoryItem;
        if(!string.IsNullOrEmpty(category))
        {
            query = query.Where(i =>i.Category == category);
        }
            query = sortBy?.ToLower()switch
        {
         "price" => query.OrderBy(i => i.Price),
         "quantity" => query.OrderBy (i => i.Quantity),
          _ => query.OrderBy (i => i.Name)        
        };
        var items = await query
        .Skip((page -1) * pageSize)
        .Take(pageSize)
        .ToListAsync();

        return Ok(items);
    }
    [HttpGet("{id}")]
    public async Task <ActionResult<InventoryItem>>GetInventoryItem(int id)
    {
        var item = await _context.InventoryItem.FindAsync(id);
        if (item == null)
        {
            return NotFound ($"Item with id {id} not found.");
        }
        return Ok(item);
    }

    [HttpPost]
    public async Task <ActionResult<InventoryItem>>CreateInventoryItem(InventoryItem item)
    {_context.InventoryItem.Add(item);
    await _context.SaveChangesAsync();
    return CreatedAtAction(nameof(GetInventoryItem),
    new {id = item.Id}, item);
    }
}


