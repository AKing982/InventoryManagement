namespace InventoryManagement.Model;

public class Warehouse
{
    private int _Id { get; set; }
    private string _Name { get; set; }
    private Address _Address { get; set; }

    private List<Supplier> _suppliers { get; set; }

    public Warehouse(int id, string name, Address address)
    {
        _Id = id;
        _Name = name;
        _Address = address;
    }
}