using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InventoryManagement.DataModel;

[Table("Contacts")]
public class ContactEntity
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [Required]
    [StringLength(100)]
    public string name { get; set; }
    
    [Required]
    [StringLength(50)]
    public string email { get; set; }
    
    [Required]
    [StringLength(15)]
    public string phone { get; set; }
    
    
}