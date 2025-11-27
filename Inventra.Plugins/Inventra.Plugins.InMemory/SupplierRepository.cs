using Inventra.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Inventra.Plugins.InMemory
{
    public class SupplierRepository : ISupplierRepository
    {
        private readonly List<Supplier> _suppliers;

        public SupplierRepository()
        {
            _suppliers = new List<Supplier>()
            {
                new Supplier{ SupplierId = 1, SupplierName = "Tech Supplies Co.", ContactInformation = "Cicago 132" },
                new Supplier{ SupplierId = 2, SupplierName = "Gadget World", ContactInformation = "BNP 10, CH" },
                new Supplier{ SupplierId = 3, SupplierName = "Device Hub", ContactInformation = "" },
            };
        }

        public async Task<IEnumerable<Supplier>> GetAllSuppliers()
        {
            return await Task.FromResult(_suppliers);
        }
    }
}
