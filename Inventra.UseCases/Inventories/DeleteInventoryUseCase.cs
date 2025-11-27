using Inventra.UseCases.Interfaces;
using Inventra.UseCases.Inventories.interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Inventra.UseCases.Inventories
{
    public class DeleteInventoryUseCase : IDeleteInventoryUseCase
    {
        public IInventoryRepository InventoryRepository { get; }

        public DeleteInventoryUseCase(IInventoryRepository inventoryRepository)
        {
            InventoryRepository = inventoryRepository;
        }

        public async Task ExecuteAsync(int inventoryId)
        {
            await InventoryRepository.DeleteInventory(inventoryId);
        }

    }
}
