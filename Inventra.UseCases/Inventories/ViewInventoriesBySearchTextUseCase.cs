using Inventra.CoreBusiness;
using Inventra.UseCases.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Inventra.UseCases.Inventories
{
    public class ViewInventoriesBySearchTextUseCase
    {
        private readonly IInventoryRepository inventoryRepository;

        public ViewInventoriesBySearchTextUseCase(IInventoryRepository inventoryRepository)
        {
            this.inventoryRepository = inventoryRepository;
        }

        public async IEnumerable<Inventory> ExecuteAsync(string searchText = "")
        {
            return await inventoryRepository.GetInventoriesBySearchText(searchText);
        }
    }
}
