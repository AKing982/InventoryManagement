using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InventoryManagement.DataModel;

[Table("inventoryNotes")]
public class InventoryNotesEntity
{
    [Key] 
    [Column("notesId")]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int NotesId { get; set; }
    
    [Required]
    public virtual UserEntity User { get; set; }
    
    [Required]
    public virtual OrderEntity Order { get; set; }
    
    [Required]
    [StringLength(50)]
    [Column("title")]
    public string Title { get; set; }
    
    [Required]
    [StringLength(900)]
    [Column("content", TypeName = "text")]
    public string Content { get; set; }

    [StringLength(50)]
    [Column("author")]
    public string Author { get; set; }
    
    [Required]
    [Column("createdAt")]
    public DateTime CreatedAt { get; set; }
    
    [Required]
    [Column("updatedAt")]
    public DateTime UpdatedAt { get; set; }
    
    [StringLength(25)]
    [Column("noteType")]
    public string NoteType { get; set; }
    


}