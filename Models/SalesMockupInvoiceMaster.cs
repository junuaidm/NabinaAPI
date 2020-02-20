using System;
using System.Collections.Generic;

namespace Nbn.eCommenrce.ItemService.Models
{
    public partial class SalesMockupInvoiceMaster
    {
        public SalesMockupInvoiceMaster()
        {
            DeliveryNoteMaster = new HashSet<DeliveryNoteMaster>();
            StoreIssueVoucherMaster = new HashSet<StoreIssueVoucherMaster>();
        }

        public int SalesMockupInvoiceId { get; set; }
        public DateTime? SalesMockupInvoiceDate { get; set; }
        public string SalesMockupInvoiceCode { get; set; }
        public int? SalesQuoteId { get; set; }
        public int? CustomerId { get; set; }
        public int? CashCustomerId { get; set; }
        public int? CustAccntId { get; set; }
        public int? SalesPersonId { get; set; }
        public int? PaymentTermsId { get; set; }
        public DateTime? PaymentTermsDueDate { get; set; }
        public int? ContactDetId { get; set; }
        public int? ProjectId { get; set; }
        public int? CustEnquiryId { get; set; }
        public string SalesMockupInvoiceDescription { get; set; }
        public string CustomerRepresentative { get; set; }
        public int? SalesMockupInvoiceTotalNoOfSiv { get; set; }
        public int? SalesMockupInvoiceStatus { get; set; }
        public decimal? SalesMockupInvoiceTotalAmount { get; set; }
        public decimal? SalesMockupInvoiceTotalDiscountPercentage { get; set; }
        public decimal? SalesMockupInvoiceDiscountAmount { get; set; }
        public decimal? SalesMockupInvoiceDeliveryCharge { get; set; }
        public DateTime? SalesMockupInvoiceFixingDate { get; set; }
        public decimal? SalesMockupInvoiceFixingCharge { get; set; }
        public decimal? SalesMockupInvoiceBankCharge { get; set; }
        public decimal? SalesMockupInvoiceDeliveryDiscount { get; set; }
        public decimal? SalesMockupInvoiceTaxPercentage { get; set; }
        public decimal? SalesMockupInvoiceTaxAmount { get; set; }
        public decimal? SalesMockupInvoiceNetAmount { get; set; }
        public bool? SalesMockupInvoiceIsTransferedToCash { get; set; }
        public int? SalesCashInvoiceId { get; set; }
        public DateTime? SalesMockupInvoiceRetentionDate { get; set; }
        public decimal? SalesMockupInvoiceRetentionPercentage { get; set; }
        public decimal? SalesMockupInvoiceJobSize { get; set; }
        public string SalesMockupInvoiceNotes { get; set; }
        public bool? SalesMockupInvoicePrinted { get; set; }
        public string SalesMockupInvoiceAddedBy { get; set; }
        public DateTime? SalesMockupInvoiceAddedWhen { get; set; }
        public string SalesMockupInvoiceUpdatedBy { get; set; }
        public DateTime? SalesMockupInvoiceUpdatedWhen { get; set; }
        public DateTime? SalesMockupInvoiceCancelledDate { get; set; }
        public string SalesMockupInvoiceCancelledBy { get; set; }
        public string SalesInvoiceFileCode { get; set; }
        public decimal? SalesInvoiceNoOfUnits { get; set; }

        public virtual SalesPersons SalesPerson { get; set; }
        public virtual ICollection<DeliveryNoteMaster> DeliveryNoteMaster { get; set; }
        public virtual ICollection<StoreIssueVoucherMaster> StoreIssueVoucherMaster { get; set; }
    }
}
