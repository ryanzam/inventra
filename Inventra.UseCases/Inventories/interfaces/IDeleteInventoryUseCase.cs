using Inventra.UseCases.Interfaces;

namespace Inventra.UseCases.Inventories.interfaces
{
    public interface IDeleteInventoryUseCase
    {
        IInventoryRepository InventoryRepository { get; }

        Task ExecuteAsync(int inventoryId);
    }
}