namespace InventoryManagement.Model;

public class Contact
{
    private int _Id;
    private string _Name;
    private string _Email;
    private string _Phone;

    public Contact(int id, string name, string email, string phone)
    {
        _Id = id;
        _Name = name;
        _Email = email;
        _Phone = phone;
    }
}