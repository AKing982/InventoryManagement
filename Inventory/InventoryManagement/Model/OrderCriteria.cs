namespace InventoryManagement.Model;

public class OrderCriteria
{
    private decimal _TotalAmount { get; set; }
    private decimal _TaxAmount { get; set; }
    private decimal _ShippingCost { get; set; }
    private decimal _DiscountAmount { get; set; }

    public OrderCriteria(decimal totalAmount, decimal taxAmount, decimal shippingCost, decimal discountAmount)
    {
        _TotalAmount = totalAmount;
        _TaxAmount = taxAmount;
        _ShippingCost = shippingCost;
        _DiscountAmount = discountAmount;
    }
}