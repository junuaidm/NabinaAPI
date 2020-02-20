using System;
using System.Collections.Generic;

namespace Nbn.eCommenrce.ItemService.Models
{
    public partial class SalesCreditInvoiceMaster
    {
        public SalesCreditInvoiceMaster()
        {
            DeliveryNoteMaster = new HashSet<DeliveryNoteMaster>();
            StoreIssueVoucherMaster = new HashSet<StoreIssueVoucherMaster>();
        }

        public int SalesCreditInvoiceId { get; set; }
        public DateTime? SalesCreditInvoiceDate { get; set; }
        public string SalesCreditInvoiceCode { get; set; }
        public int? SalesQuoteId { get; set; }
        public int? InvoiceItemCategoryId { get; set; }
        public int? CashCustomerId { get; set; }
        public int? CustomerId { get; set; }
        public int? CustAccntId { get; set; }
        public int? SalesPersonId { get; set; }
        public int? PaymentTermsId { get; set; }
        public DateTime? PaymentTermsDueDate { get; set; }
        public int? ContactDetId { get; set; }
        public int? ProjectId { get; set; }
        public int? SalesContractId { get; set; }
        public int? CustEnquiryId { get; set; }
        public string SalesCreditInvoiceDescription { get; set; }
        public string CustomerRepresentative { get; set; }
        public int? SalesCreditInvoiceStatus { get; set; }
        public int? SalesCreditInvoiceTotalNoOfSiv { get; set; }
        public decimal? SalesCreditInvoiceTotalAmount { get; set; }
        public decimal? SalesCreditInvoiceDeliveryCharge { get; set; }
        public DateTime? SalesCreditInvoiceFixingDate { get; set; }
        public decimal? SalesCreditInvoiceFixingCharge { get; set; }
        public decimal? SalesCreditInvoiceBankCharge { get; set; }
        public decimal? SalesCreditInvoiceDeliveryDiscount { get; set; }
        public decimal? SalesCreditInvoiceDrawingChargeDiscount { get; set; }
        public decimal? SalesCreditInvoiceTaxPercentage { get; set; }
        public decimal? SalesCreditInvoiceTaxAmount { get; set; }
        public decimal? SalesCreditInvoiceDiscountAmount { get; set; }
        public decimal? SalesCreditInvoiceTotalDiscountPercentage { get; set; }
        public decimal? SalesCreditInvoiceNetAmount { get; set; }
        public DateTime? SalesCreditInvoiceRetentionDate { get; set; }
        public decimal? SalesCreditInvoiceRetentionPercentage { get; set; }
        public int? DrawingChargeReceiptId { get; set; }
        public decimal? SalesCreditInvoiceJobSize { get; set; }
        public string SalesCreditInvoiceNotes { get; set; }
        public bool? SalesCreditInvoicePrinted { get; set; }
        public DateTime? SalesCreditInvoiceGeneratedDate { get; set; }
        public DateTime? SalesCreditInvoiceCancelledDate { get; set; }
        public string SalesCreditInvoiceCancelledBy { get; set; }
        public string SalesInvoiceDiscountDescription { get; set; }
        public decimal? SalesInvoiceNoOfUnits { get; set; }
        public string SalesInvoiceFileCode { get; set; }
        public string SalesCreditInvoiceAddedBy { get; set; }
        public DateTime? SalesCreditInvoiceAddedWhen { get; set; }
        public string SalesCreditInvoiceUpdatedBy { get; set; }
        public DateTime? SalesCreditInvoiceUpdatedWhen { get; set; }

        public virtual SalesPersons SalesPerson { get; set; }
        public virtual ICollection<DeliveryNoteMaster> DeliveryNoteMaster { get; set; }
        public virtual ICollection<StoreIssueVoucherMaster> StoreIssueVoucherMaster { get; set; }
    }
}
