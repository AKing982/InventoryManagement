namespace InventoryManagement.Model;

public class Customer
{
    private int _CustomerId { get; set; }
    private string _CustomerName { get; set; }
    private Address _CustomerAddress { get; set; }
    private DateTime _DateAdded { get; set; }
    
    public Customer(int customerId, 
                    string customerName, 
                    Address customerAddress,
                    DateTime dateAdded)
    {
        _CustomerId = customerId;
        _CustomerName = customerName;
        _CustomerAddress = customerAddress;
        _DateAdded = dateAdded;
    }
}