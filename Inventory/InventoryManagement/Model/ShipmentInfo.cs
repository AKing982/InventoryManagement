namespace InventoryManagement.Model;

public class ShipmentInfo
{
    private DateTime? _ShippedDate { get; set; }
    private DateTime? _DeliveredDate { get; set; }
    
    private TrackingNumber _trackingNumber { get; set; }
    
    private ShippingMethod _shippingMethod { get; set; }
    
    private string _CarrierName { get; set; }
    
    private decimal _ShippingCost { get; set; }
    
    private Address _ShippingAddress { get; set; }

    private List<Notes> ShippingNotes { get; set; }

    public ShipmentInfo(DateTime? shippedDate, DateTime? deliveredDate)
    {
        _ShippedDate = shippedDate;
        _DeliveredDate = deliveredDate;
    }
}