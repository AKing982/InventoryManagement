using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace InventoryManagement.DataModel;

[Table("Users")]
public class UserEntity
{
    [Key] 
    [Column("user_id")]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int user_id { get; set; }

    [Required] 
    [StringLength(25)] 
    [Column("first_name")]
    public string first_name { get; set; }
    
    [Required]
    [StringLength(25)]
    [Column("last_name")]
    public string last_name { get; set; }
    
    [Required]
    [StringLength(25)]
    [Column("username")]
    public string username { get; set; }
    
    [Required]
    [StringLength(255)]
    [Column("password")]
    public string password { get; set; }
    
    [StringLength(255)]
    [Column("email")]
    public string email { get; set; }

    [Required]
    [Column("isActive")]
    public Boolean isActive { get; set; }
    
}