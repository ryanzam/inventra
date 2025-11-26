using Inventra.Entities;
using Inventra.UseCases.Interfaces;
using Inventra.UseCases.Inventories.interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Inventra.UseCases.Inventories
{
    public class AddInventoryUseCase : IAddInventoryUseCase
    {
        public IInventoryRepository InventoryRepository { get; }

        public AddInventoryUseCase(IInventoryRepository inventoryRepository)
        {
            InventoryRepository = inventoryRepository;
        }

        public async Task<Inventory> ExecuteAsync(Inventory inventory)
        {
            return await InventoryRepository.AddInventory(inventory);
        }

    }
}
