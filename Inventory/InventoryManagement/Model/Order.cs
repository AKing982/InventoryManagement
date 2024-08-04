using InventoryManagement.Model;

namespace InventoryManagement.DataModel;

public class Order
{
    private int _OrderId { get; set; }
    private string _OrderNumber { get; set; }
    private DateTime _OrderDate { get; set; }
    private OrderStatus _OrderStatus { get; set; }
    private OrderType _OrderType { get; set; }
    private Customer _Customer { get; set; }
    private Supplier _supplier { get; set; }
    private List<OrderItem> _Items { get; set; }
    private OrderCriteria _orderCriteria { get; set; }
    private Address _ShippingAddress { get; set; }
    private Address _BillingAddress { get; set; }
    private PaymentMethod _PaymentMethod { get; set; }
    private ShipmentInfo _shipmentInfo { get; set; }
    


}