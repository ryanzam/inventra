using Inventra.Entities;
using Inventra.UseCases.Interfaces;

namespace Inventra.UseCases.Inventories.interfaces
{
    public interface ISaveInventoryUseCase
    {
        Task<Inventory> ExecuteAsync(Inventory inventory);
    }
}