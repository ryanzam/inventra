using Inventra.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Inventra.UseCases.Interfaces
{
    public interface IInventoryRepository
    {
        Task<IEnumerable<Inventory>> GetInventoriesBySearchText(string searchText);
    }
}
