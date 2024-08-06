using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using InventoryManagement.Model;

namespace InventoryManagement.DataModel;

[Table("Orders")]
public class OrderEntity
{
    [Key]
    [Column("order_id")]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int order_Id { get; set; }

    [Required]
    [Column("orderNumber")]
    [StringLength(50)]
    public string OrderNumber { get; set; }

    [Required]
    [Column("OrderDate")]
    public DateTime OrderDate { get; set; }

    [Required]
    [Column("OrderStatus")]
    public OrderStatus OrderStatus { get; set; }

    [Required]
    [Column("OrderType")]
    public OrderType OrderType { get; set; }

    [Required]
    public virtual CustomerEntity CustomerEntity { get; set; }
    
    // [Required]
    // public virtual SupplierEntity Supplier { get; set; }
    
    [Required]
    public virtual OrderCriteria OrderCriteria { get; set; }
    
    [Required]
    public virtual string ShippingAddress { get; set; }
    
    [Required]
    public virtual string BillingAddress { get; set; }

    [Required]
    public string PaymentMethod { get; set; }
    
    [Required]
    public DateTime shippedDate { get; set; }
    
    [Required]
    public DateTime DeliveredDate { get; set; }

    [Required]
    public virtual InventoryNotesEntity InventoryNotesEntity { get; set; }
    
    [Required]
    public int CreatedByUserId { get; set; }
    
    [Required]
    public DateTime CreatedAt { get; set; }
    
    [Required]
    public DateTime UpdatedAt { get; set; }
    

    public OrderEntity()
    {
        
    }
    
    
}