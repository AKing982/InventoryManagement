namespace InventoryManagement.domain;

public record SupplierDTO(int id, string name, string email, string phone, List<string> products);
