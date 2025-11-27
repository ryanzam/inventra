using Inventra.Entities;

namespace Inventra.Plugins.InMemory
{
    public interface ISupplierRepository
    {
        Task<IEnumerable<Supplier>> GetAllSuppliers();
    }
}