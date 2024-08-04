namespace InventoryManagement.Model;

public class Supplier
{
    private int _Id { get; set; }
    private string _Name { get; set; }
    private Contact _ContactInfo { get; set; }
    private List<Product> _Products { get; set; }

    public Supplier(int id, string name, Contact contact, List<Product> products)
    {
        _Id = id;
        _Name = name;
        _ContactInfo = contact;
        _Products = products;
    }

    public int Id
    {
        get { return _Id; }
        set { _Id = value; }
    }
}