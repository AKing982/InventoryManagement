using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace InventoryManagement.DataModel;

[Table("Users")]
public class UserEntity
{
    [Key] [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int user_id { get; set; }

    [Required] [StringLength(25)] 
    public string first_name { get; set; }
    
    [Required][StringLength(25)]
    public string last_name { get; set; }
    
    
    
    
    
}