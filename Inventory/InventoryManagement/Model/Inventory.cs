namespace InventoryManagement.Model;

public class Inventory
{
    private int _Id { get; set; }
    
    private Product _Product { get; set; }
    private Warehouse _Warehouse { get; set; }
    private int _Quantity { get; set; }
    private DateTime _LastUpdated { get; set; }

    public Inventory(int id, Product product, Warehouse warehouse, int quantity,
        DateTime lastUpdated)
    {
        _Id = id;
        _Warehouse = warehouse;
        _Quantity = quantity;
        _LastUpdated = lastUpdated;
    }
    
    public int Id
    {
        get { return _Id; }
        set { _Id = value; }
    }
}