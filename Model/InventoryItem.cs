using System.ComponentModel.DataAnnotations;
namespace HardwareStoreApi.Model;

public class InventoryItem
{
    public int Id {get; set;}
    [Required]
    public string Name {get; set;} = string.Empty;
    public string Category {get; set;} = string.Empty;
    [Range (0, double.MaxValue, ErrorMessage = "price cannot be negative.")]
    public decimal Price {get; set;}
    public string Location {get; set;} = string.Empty;
    public string Brand {get; set;} = string.Empty;
    [Range (0, int.MaxValue, ErrorMessage = "Qunatity cannot be negative.")]
    public int Quantity {get; set;} 
}