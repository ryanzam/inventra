using System;
using System.Collections.Generic;
using System.Text;

namespace Inventra.Entities
{
    public class Supplier
    {
        public int SupplierId { get; set; }
        public string SupplierName { get; set; } = "";
        public string ContactInformation { get; set; } = "";
    }
}
