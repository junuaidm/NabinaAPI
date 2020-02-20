using System;
using System.Collections.Generic;

namespace Nbn.eCommenrce.ItemService.Models
{
    public partial class Suppliers
    {
        public Suppliers()
        {
            Items = new HashSet<Items>();
            SalesGroupDiscount = new HashSet<SalesGroupDiscount>();
        }

        public int SupplierId { get; set; }
        public string SupplierCode { get; set; }
        public string SupplierName { get; set; }
        public string SupplierSince { get; set; }
        public string SupplierAddress { get; set; }
        public string SupplierTelNo { get; set; }
        public string SupplierFaxNo { get; set; }
        public string SupplierWebSite { get; set; }
        public string SupplierEmail { get; set; }
        public string SupplierCountry { get; set; }
        public byte? SupplierIsActive { get; set; }
        public int? SupplierTypeId { get; set; }
        public int? LedgerAccountId { get; set; }
        public string SupplierAddedBy { get; set; }
        public DateTime? SupplierAddedWhen { get; set; }
        public string SupplierUpdatedBy { get; set; }
        public DateTime? SupplierUpdatedWhen { get; set; }

        public virtual ICollection<Items> Items { get; set; }
        public virtual ICollection<SalesGroupDiscount> SalesGroupDiscount { get; set; }
    }
}
