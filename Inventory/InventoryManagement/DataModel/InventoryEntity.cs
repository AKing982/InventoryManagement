using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InventoryManagement.DataModel;

[Table("Inventory")]
public class InventoryEntity
{
    [Key] 
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public string Id { get; set; }
    
    [ForeignKey("id")]
    public ProductEntity ProductEntity { get; set; }
    
    [ForeignKey("id")]
    public WarehouseEntity WarehouseEntity { get; set; }
    
    [Required]
    public int Quantity { get; set; }
    
    public DateTime LastUpdated { get; set; }
}