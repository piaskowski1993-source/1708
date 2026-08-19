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
    public async Task <ActionResult<IEnumerable<InventoryItem>>>GetInventoryItems()
    {throw new NotImplementedException();}

    [HttpGet("{id}")]
    public async Task <ActionResult<InventoryItem>>GetInventoryItem(int id)
    {throw new NotImplementedException();}

    [HttpPost]
    public async Task <ActionResult<InventoryItem>>CreateInventoryItem(InventoryItem item)
    {throw new NotImplementedException();}
}


