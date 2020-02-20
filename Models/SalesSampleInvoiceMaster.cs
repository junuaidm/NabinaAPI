using System;
using System.Collections.Generic;

namespace Nbn.eCommenrce.ItemService.Models
{
    public partial class SalesSampleInvoiceMaster
    {
        public SalesSampleInvoiceMaster()
        {
            DeliveryNoteMaster = new HashSet<DeliveryNoteMaster>();
            StoreIssueVoucherMaster = new HashSet<StoreIssueVoucherMaster>();
        }

        public int SalesSampleInvoiceId { get; set; }
        public DateTime? SalesSampleInvoiceDate { get; set; }
        public string SalesSampleInvoiceCode { get; set; }
        public int? SalesQuoteId { get; set; }
        public int? InvoiceItemCategoryId { get; set; }
        public int? CustomerId { get; set; }
        public int? CashCustomerId { get; set; }
        public int? CustAccntId { get; set; }
        public int? SalesPersonId { get; set; }
        public int? PaymentTermsId { get; set; }
        public DateTime? PaymentTermsDueDate { get; set; }
        public int? ContactDetId { get; set; }
        public int? ProjectId { get; set; }
        public int? SalesContractId { get; set; }
        public int? CustEnquiryId { get; set; }
        public string SalesSampleInvoiceDescription { get; set; }
        public string CustomerRepresentative { get; set; }
        public int? SalesSampleInvoiceTotalNoOfSiv { get; set; }
        public int? SalesSampleInvoiceStatus { get; set; }
        public decimal? SalesSampleInvoiceTotalAmount { get; set; }
        public decimal? SalesSampleInvoiceTotalDiscountPercentage { get; set; }
        public decimal? SalesSampleInvoiceDiscountAmount { get; set; }
        public decimal? SalesSampleInvoiceDeliveryCharge { get; set; }
        public DateTime? SalesSampleInvoiceFixingDate { get; set; }
        public decimal? SalesSampleInvoiceFixingCharge { get; set; }
        public decimal? SalesSampleInvoiceBankCharge { get; set; }
        public decimal? SalesSampleInvoiceDeliveryDiscount { get; set; }
        public decimal? SalesSampleInvoiceTaxPercentage { get; set; }
        public decimal? SalesSampleInvoiceTaxAmount { get; set; }
        public decimal? SalesSampleInvoiceNetAmount { get; set; }
        public bool? SalesSampleInvoiceIsTransferedToCash { get; set; }
        public int? SalesCashInvoiceId { get; set; }
        public bool? SalesSampleInvoicePrinted { get; set; }
        public DateTime? SalesSampleInvoiceRetentionDate { get; set; }
        public decimal? SalesSampleInvoiceRetentionPercentage { get; set; }
        public decimal? SalesSampleInvoiceJobSize { get; set; }
        public string SalesSampleInvoiceNotes { get; set; }
        public string SalesSampleInvoiceAddedBy { get; set; }
        public DateTime? SalesSampleInvoiceAddedWhen { get; set; }
        public string SalesSampleInvoiceUpdatedBy { get; set; }
        public DateTime? SalesSampleInvoiceUpdatedWhen { get; set; }
        public DateTime? SalesSampleInvoiceCancelledDate { get; set; }
        public string SalesSampleInvoiceCancelledBy { get; set; }
        public string SalesInvoiceFileCode { get; set; }
        public decimal? SalesInvoiceNoOfUnits { get; set; }

        public virtual SalesPersons SalesPerson { get; set; }
        public virtual ICollection<DeliveryNoteMaster> DeliveryNoteMaster { get; set; }
        public virtual ICollection<StoreIssueVoucherMaster> StoreIssueVoucherMaster { get; set; }
    }
}
