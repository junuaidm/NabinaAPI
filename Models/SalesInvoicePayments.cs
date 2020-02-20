using System;
using System.Collections.Generic;

namespace Nbn.eCommenrce.ItemService.Models
{
    public partial class SalesInvoicePayments
    {
        public int InvPaymentId { get; set; }
        public int? SalesCashInvoiceId { get; set; }
        public int? SalesCreditInvoiceId { get; set; }
        public int? PdtypeId { get; set; }
        public decimal? InvPaymentAmount { get; set; }
        public string InvPaymentDocumentNo { get; set; }
        public DateTime? InvPaymentDocumentDate { get; set; }
        public string InvPaymentBankName { get; set; }
        public int? CardsId { get; set; }
        public string InvPaymentAddedBy { get; set; }
        public DateTime? InvPaymentAddedWhen { get; set; }
        public string InvPaymentUpdatedBy { get; set; }
        public DateTime? InvPaymentUpdatedWhen { get; set; }
    }
}
