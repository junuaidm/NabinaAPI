using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Nbn.eCommenrce.ItemService.Models
{
    public partial class CustomerCreditDetails
    {
        [Key]
        public int CusCreditId { get; set; }
        public int? CustomerId { get; set; }
        public int? CustAccntId { get; set; }
        public int? SalesCreditInvoiceId { get; set; }
        public bool? CustCreditHasPaidAdvance { get; set; }
        public decimal? CustCreditAdvancePercent { get; set; }
        public decimal? CustCreditAdvanceAmount { get; set; }
        public decimal? CustMaximumCreditLimit { get; set; }
        public DateTime? CustCreditOpeningDate { get; set; }
        public DateTime? CustCreditLimitValidUpto { get; set; }
        public string CustCreditapprovedBy { get; set; }
        public DateTime? CustCreditapprovedDate { get; set; }
        public string CustCreditDescription { get; set; }
        public decimal? CustCreditUtilisedAgainstInvoice { get; set; }
        public string CustByLpo { get; set; }
        public decimal? CustByCash { get; set; }
        public decimal? CustByCurrentCheque { get; set; }
        public decimal? CustByPdcheque { get; set; }
        public DateTime? CustCurrentChequeDate { get; set; }
        public DateTime? CustPdchequeDate { get; set; }
        public string SalesInvoiceCode { get; set; }
        public bool? CustCreditPaymentAfterDelivery { get; set; }
        public int? CustCreditStatus { get; set; }
        public string CustCreditAddedBy { get; set; }
        public DateTime? CustCreditAddedWhen { get; set; }
        public string CustCreditUpdatedBy { get; set; }
        public DateTime? CustCreditUpdatedWhen { get; set; }

        public virtual CustomerMaster Customer { get; set; }
    }
}
