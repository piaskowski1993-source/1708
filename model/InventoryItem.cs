namespace HardwareStoreApi.Model;

public class InventoryItem
{
    public int Id {get; set;}
    public string Name {get; set;} = string.Empty;
    public string Category {get; set;} = string.Empty;
    public decimal Price {get; set;}
    public string Location {get; set;} = string.Empty;
    public string Brand {get; set;} = string.Empty;
    public int Quantity {get; set;} 
}