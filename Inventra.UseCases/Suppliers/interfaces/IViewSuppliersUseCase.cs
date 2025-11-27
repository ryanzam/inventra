using Inventra.Entities;

namespace Inventra.UseCases.Suppliers.interfaces
{
    public interface IViewSuppliersUseCase
    {
        Task<IEnumerable<Supplier>> ExecuteAsync();
    }
}