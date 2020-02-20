using System;
using System.Collections.Generic;

namespace Nbn.eCommenrce.ItemService.Models
{
    public partial class SalesInvoiceDocuments
    {
        public int SalesInvoiceDocId { get; set; }
        public int? SalesCashInvoiceId { get; set; }
        public int? SalesCreditInvoiceId { get; set; }
        public int? SalesMockupInvoiceId { get; set; }
        public int? SalesSampleInvoiceId { get; set; }
        public string SalesInvoiceDocType { get; set; }
        public string SalesInvoiceDocName { get; set; }
        public string SalesInvoiceDocDesc { get; set; }
        public string SalesInvoiceDocFileType { get; set; }
        public string SalesInvoiceDocFileName { get; set; }
        public bool? SalesInvoiceDocIsActive { get; set; }
        public string SalesInvoiceDocAddedBy { get; set; }
        public DateTime? SalesInvoiceDocAddedWhen { get; set; }
        public string SalesInvoiceDocUpdatedBy { get; set; }
        public DateTime? SalesInvoiceDocUpdatedWhen { get; set; }
    }
}
