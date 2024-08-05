namespace InventoryManagement.Workbench.Converter;

public interface EntityConverter<E, M> where E : class
                                       where M : class
{
    M convertFromEntity(E entity);
    E convertToEntity(M model);
    IEnumerable<E> ConvertToEntities(IEnumerable<M> models);
    IEnumerable<M> convertFromEntities(IEnumerable<E> entities);
}