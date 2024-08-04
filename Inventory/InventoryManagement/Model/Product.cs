namespace InventoryManagement.Model;

public class Product
{
    private int _Id { get; set; }
    private string _Name { get; set; }
    private string _SKU { get; set; }
    private string _Description { get; set; }
    private decimal _Price { get; set; }
    private decimal _Quantity { get; set; }
    private string _Category { get; set; }

    public Product(int id, string name, string sku, string descr, decimal price, decimal quantity, string category)
    {
        _Id = id;
        _Name = name;
        _SKU = sku;
        _Description = descr;
        _Price = price;
        _Quantity = quantity;
        _Category = category;
    }

    public int Id
    {
        get { return _Id;  }
        set { _Id = value; }
    }

    public string Name
    {
        get { return _Name; }
        set { _Name = value; }
    }
    
}