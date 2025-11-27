using Inventra.Entities;
using Inventra.Plugins.InMemory;
using Inventra.UseCases.Suppliers.interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Inventra.UseCases.Suppliers
{
    public class ViewSuppliersUseCase : IViewSuppliersUseCase
    {
        private readonly ISupplierRepository supplierRepository;

        public ViewSuppliersUseCase(ISupplierRepository supplierRepository)
        {
            this.supplierRepository = supplierRepository;
        }

        public async Task<IEnumerable<Supplier>> ExecuteAsync()
        {
            return await supplierRepository.GetAllSuppliers();
        }
    }
}
