using Inventra.Entities;
using Inventra.UseCases.Interfaces;
using Inventra.UseCases.Inventories.interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Inventra.UseCases.Inventories
{
    public class ViewInventoriesBySearchTextUseCase : IViewInventoriesBySearchTextUseCase
    {
        private readonly IInventoryRepository inventoryRepository;

        public ViewInventoriesBySearchTextUseCase(IInventoryRepository inventoryRepository)
        {
            this.inventoryRepository = inventoryRepository;
        }

        public async Task<IEnumerable<Inventory>> ExecuteAsync(string searchText = "")
        {
            return await inventoryRepository.GetInventoriesBySearchText(searchText);
        }
    }
}
