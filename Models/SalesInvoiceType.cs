using System;
using System.Collections.Generic;

namespace Nbn.eCommenrce.ItemService.Models
{
    public partial class SalesInvoiceType
    {
        public int SalesInvoiceTypeId { get; set; }
        public string SalesInvoiceTypeName { get; set; }
        public bool? SalesInvoiceTypeIsActive { get; set; }
        public string SalesInvoiceTypeDescription { get; set; }
        public string SalesInvoiceTypeAddedBy { get; set; }
        public DateTime? SalesInvoiceTypeAddedWhen { get; set; }
        public string SalesInvoiceTypeUpdatedBy { get; set; }
        public DateTime? SalesInvoiceTypeUpdatedWhen { get; set; }
    }
}
