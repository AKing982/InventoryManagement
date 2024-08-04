using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InventoryManagement.DataModel;

[Table("Warehouse")]
public class WarehouseEntity
{
    [Key] 
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    
    [Required]
    [StringLength(75)]
    public string Name { get; set; }
    
    [Required]
    [StringLength(50)]
    public string Address { get; set; }
    
}