using Microsoft.EntityFrameworkCore;
using HardwareStoreApi.Model;

namespace HardwareStoreApi.Data;

public class AppDbContext : DbContext
{
    public AppDbContext( DbContextOptions <AppDbContext> options) : base(options){}
    public DbSet <InventoryItem> InventoryItem {get; set;} = null!;
}