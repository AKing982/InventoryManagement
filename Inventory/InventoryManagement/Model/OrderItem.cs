using InventoryManagement.DataModel;

namespace InventoryManagement.Model;

public class OrderItem
{
    private int _Id { get; set; }
    private Order _Order { get; set; }
    private Product _Product { get; set; }
    private int _Quantity { get; set; }
    private decimal _UnitPrice { get; set; }
    private decimal _Discount { get; set; }
    private decimal _TotalPrice { get; set; }
    
    
}