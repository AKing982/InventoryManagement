namespace InventoryManagement.domain;

public record InventoryDTO(int id,
    string productName,
    string SKU,
    string description,
    decimal price, 
    decimal quantity, 
    string category,
    string warehouseName,
    string address,
    DateTime lastUpdated);