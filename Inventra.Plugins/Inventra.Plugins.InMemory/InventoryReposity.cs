using Inventra.Entities;
using Inventra.UseCases.Interfaces;
using System.Reflection.Metadata.Ecma335;

namespace Inventra.Plugins.InMemory
{
    public class InventoryRepository : IInventoryRepository
    {
        private List<Inventory> _inventories;

        public InventoryRepository()
        {
            _inventories = new List<Inventory>()
            {
                new Inventory{ InventoryId = 1, InventoryName = "Screen", Quantity = 50, Price = 100 },
                new Inventory{ InventoryId = 2, InventoryName = "Keyboard", Quantity = 30, Price = 50 },
                new Inventory{ InventoryId = 3, InventoryName = "Mouse", Quantity = 100, Price = 20 },
                new Inventory{ InventoryId = 4, InventoryName = "CPU", Quantity = 20, Price = 300 },
                new Inventory{ InventoryId = 5, InventoryName = "SSD", Quantity = 25, Price = 80 },
            };
        }
        public async Task<IEnumerable<Inventory>> GetInventoriesBySearchText(string searchText)
        {
            if(string.IsNullOrWhiteSpace(searchText))   
            {
                return await Task.FromResult(_inventories);
            }

            return _inventories.Where(i => i.InventoryName.Contains(searchText, StringComparison.OrdinalIgnoreCase))    ;
        }

        public async Task<Inventory> SaveInventory(Inventory inventory)
        {
            if(inventory.InventoryId == 0)
            {
                var maxId = _inventories.Max(i => i.InventoryId);
                inventory.InventoryId = maxId + 1;
                _inventories.Add(inventory);
            }
            else
            {
                var existingInventory = _inventories.FirstOrDefault(i => i.InventoryId == inventory.InventoryId);
                if(existingInventory != null)
                {
                    existingInventory.InventoryName = inventory.InventoryName;
                    existingInventory.Quantity = inventory.Quantity;
                    existingInventory.Price = inventory.Price;
                }
            }
            return await Task.FromResult(inventory);
        }
    }
}
