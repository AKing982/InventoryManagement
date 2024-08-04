using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InventoryManagement.DataModel;

[Table("Products")]
public class ProductEntity
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    
    [Required]
    [StringLength(100)]
    public string Name { get; set; }
    
    [Required]
    [StringLength(20)]
    public string SKU { get; set; }
    
    [StringLength(500)]
    public string Description { get; set; }
    
    [Column(TypeName = "decimal(18, 2)")]
    public decimal Price { get; set; }
    
    public int Quantity { get; set; }
    
    [ForeignKey("Category")]
    public int categoryId { get; set; }
    
  //  public virtual CategoryEntity CategoryEntity { get; set; }
    
    public DateTime CreatedAt { get; set; }
    
    public DateTime? UpdatedAt { get; set; }
}