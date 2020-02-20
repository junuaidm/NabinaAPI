using System;
using System.Collections.Generic;

namespace Nbn.eCommenrce.ItemService.Models
{
    public partial class SalesContractPayments
    {
        public int SalesContractPaymentId { get; set; }
        public int? SalesContractId { get; set; }
        public int? SalesQuoteId { get; set; }
        public int? SalesContractPaymentTermId { get; set; }
        public int? SalesContractPaymentTypeId { get; set; }
        public decimal? SalesContractPaymentPercentageOfTotalAmount { get; set; }
        public decimal? SalesContractPaymentAmount { get; set; }
        public DateTime? SalesContractPaymentChequeDate { get; set; }
        public string SalesContractPaymentDescription { get; set; }
        public string SalesContractPaymentDescriptionArabic { get; set; }
        public bool? SalesContractPaymentIsBeforeDelivery { get; set; }
        public bool? SalesContractPaymentIsAfterDelivery { get; set; }
        public int? SalesContractPaymentTermPeriod { get; set; }
        public DateTime? SalesContractPaymentAddedWhen { get; set; }
        public string SalesContractPaymentAddedBy { get; set; }
        public DateTime? SalesContractPaymentUpdatedWhen { get; set; }
        public string SalesContractPaymentUpdatedBy { get; set; }
    }
}
