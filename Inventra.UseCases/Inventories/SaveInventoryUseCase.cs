using Inventra.Entities;
using Inventra.UseCases.Interfaces;
using Inventra.UseCases.Inventories.interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Inventra.UseCases.Inventories
{
    public class SaveInventoryUseCase : ISaveInventoryUseCase
    {
        public IInventoryRepository InventoryRepository { get; }
        public List<Inventory> Inventories { get; set; } = new List<Inventory>();

        public SaveInventoryUseCase(IInventoryRepository inventoryRepository)
        {
            InventoryRepository = inventoryRepository;
        }

        public async Task<Inventory> ExecuteAsync(Inventory inventory)
        {
            return await InventoryRepository.SaveInventory(inventory);
        }
    }
}
