namespace InventoryManagement.Model;

public class Notes
{
    private int _NoteId { get; set; }
    private string _Title { get; set; }
    private string _Text { get; set; }
    private string _Author { get; set; }
    private DateTime _CreatedAt { get; set; }
    private DateTime _UpdatedAt { get; set; }
    private NoteType _NoteType { get; set; }

    public Notes(int noteId, string title, string text, string author, DateTime createdAt, DateTime updated, NoteType noteType)
    {
        _NoteId = noteId;
        _Title = title;
        _Text = text;
        _Author = author;
        _CreatedAt = createdAt;
        _UpdatedAt = updated;
        _NoteType = noteType;
    }
    
    
}