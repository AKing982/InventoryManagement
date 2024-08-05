using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using InventoryManagement.Model;

namespace InventoryManagement.DataModel;

[Table("Orders")]
public class OrderEntity
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int OrderId { get; set; }

    [Required]
    [StringLength(50)]
    public string OrderNumber { get; set; }

    [Required]
    public DateTime OrderDate { get; set; }

    [Required]
    public OrderStatus OrderStatus { get; set; }

    [Required]
    public OrderType OrderType { get; set; }

    [ForeignKey("Customer")]
    public int? CustomerId { get; set; }

    [ForeignKey("Supplier")]
    public int? SupplierId { get; set; }
    public virtual ICollection<OrderItem> Items { get; set; }

    [ForeignKey("OrderCriteria")]
    public int OrderCriteriaId { get; set; }
    
    public virtual string ShippingAddress { get; set; }

    [ForeignKey("BillingAddress")]
    public virtual string BillingAddress { get; set; }

    [Required]
    public string PaymentMethod { get; set; }

    [ForeignKey("ShipmentInfo")]
    public int? ShipmentInfoId { get; set; }
    
    public virtual ShipmentInfo ShipmentInfo { get; set; }

    public OrderEntity()
    {
        Items = new List<OrderItem>();
    }
    
    
}