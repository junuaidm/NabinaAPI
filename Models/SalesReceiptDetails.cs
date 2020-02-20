using System;
using System.Collections.Generic;

namespace Nbn.eCommenrce.ItemService.Models
{
    public partial class SalesReceiptDetails
    {
        public int SrdetailId { get; set; }
        public int? SalesReceiptId { get; set; }
        public int? SalesCashInvoiceId { get; set; }
        public int? SalesCreditInvoiceId { get; set; }
        public int? Memid { get; set; }
        public decimal? SrdetailAmount { get; set; }
        public bool? SrdetailAmountIsAdvance { get; set; }
        public string SrdetailRemarks { get; set; }
        public string SrdetailAddedBy { get; set; }
        public DateTime? SrdetailAddedWhen { get; set; }
        public string SrdetailUpdatedBy { get; set; }
        public DateTime? SrdetailUpdatedWhen { get; set; }
    }
}
