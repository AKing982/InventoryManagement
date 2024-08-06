using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InventoryManagement.DataModel;

[Table("customer")]
public class CustomerEntity
{
    [Key]
    [Column("CustomerId")]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public string CustomerId { get; set; }
    
    [Required]
    [StringLength(255)]
    [Column("Name")]
    public string Name { get; set; }
    
    [Required]
    [StringLength(500)]
    [Column("Address")]
    public string Address { get; set; }

    [Column("DateAdded")]
    public DateTime dateAdded { get; set; }




}