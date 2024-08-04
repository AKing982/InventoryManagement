namespace InventoryManagement.domain;

public record ProductDTO(int id, 
                         string name, 
                         string description, 
                         string SKU,
                         string price,
                         string quantity,
                         string category);
                         