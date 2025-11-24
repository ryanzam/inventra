using Inventra.Entities;

namespace Inventra.UseCases.Inventories.interfaces
{
    public interface IViewInventoriesBySearchTextUseCase
    {
        Task<IEnumerable<Inventory>> ExecuteAsync(string searchText = "");
    }
}