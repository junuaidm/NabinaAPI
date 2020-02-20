using System;
using System.Collections.Generic;

namespace Nbn.eCommenrce.ItemService.Models
{
    public partial class SalesInvoiceTerms
    {
        public int InvTermId { get; set; }
        public int? TermsId { get; set; }
        public int? InvTermsTypeId { get; set; }
        public int? SalesCashInvoiceId { get; set; }
        public int? SalesCreditInvoiceId { get; set; }
        public int? SalesMockupInvoiceId { get; set; }
        public int? SalesSampleInvoiceId { get; set; }
        public string InvTermAddedBy { get; set; }
        public DateTime? InvTermAddedWhen { get; set; }
        public string InvTermUpdatedBy { get; set; }
        public DateTime? InvTermUpdatedWhen { get; set; }
    }
}
