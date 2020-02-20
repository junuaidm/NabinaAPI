using System;
using System.Collections.Generic;

namespace Nbn.eCommenrce.ItemService.Models
{
    public partial class SalesCashInvoiceMaster
    {
        public SalesCashInvoiceMaster()
        {
            ChequeRegister = new HashSet<ChequeRegister>();
            DeliveryNoteMaster = new HashSet<DeliveryNoteMaster>();
            StoreIssueVoucherMaster = new HashSet<StoreIssueVoucherMaster>();
        }

        public int SalesCashInvoiceId { get; set; }
        public DateTime? SalesCashInvoiceDate { get; set; }
        public string SalesCashInvoiceCode { get; set; }
        public int? SalesQuoteId { get; set; }
        public int? InvoiceItemCategoryId { get; set; }
        public int? CustomerId { get; set; }
        public int? CashCustomerId { get; set; }
        public int? SalesPersonId { get; set; }
        public int? PaymentTermsId { get; set; }
        public DateTime? PaymentTermsDueDate { get; set; }
        public int? ContactDetId { get; set; }
        public int? ProjectId { get; set; }
        public int? SalesContractId { get; set; }
        public int? CustEnquiryId { get; set; }
        public string SalesCashInvoiceDescription { get; set; }
        public string CustomerRepresentative { get; set; }
        public int? SalesCashInvoiceInvoiceStatus { get; set; }
        public int? SalesCashInvoiceTotalNoOfSiv { get; set; }
        public decimal? SalesCashInvoiceTotalAmount { get; set; }
        public decimal? SalesCashInvoiceTotalDiscountPercentage { get; set; }
        public decimal? SalesCashInvoiceDiscountAmount { get; set; }
        public decimal? SalesCashInvoiceDeliveryCharge { get; set; }
        public DateTime? SalesCashInvoiceFixingDate { get; set; }
        public decimal? SalesCashInvoiceFixingCharge { get; set; }
        public decimal? SalesCashInvoiceBankCharge { get; set; }
        public decimal? SalesCashInvoiceDeliveryDiscount { get; set; }
        public decimal? SalesCashInvoiceDrawingChargeDiscount { get; set; }
        public decimal? SalesCashInvoiceTaxPercentage { get; set; }
        public decimal? SalesCashInvoiceTaxAmount { get; set; }
        public decimal? SalesCashInvoiceNetAmount { get; set; }
        public DateTime? SalesCashInvoiceRetentionDate { get; set; }
        public decimal? SalesCashInvoiceRetentionPercentage { get; set; }
        public decimal? SalesCashInvoiceJobSize { get; set; }
        public string SalesCashInvoiceNotes { get; set; }
        public decimal? SalesInvoiceNoOfUnits { get; set; }
        public int? DrawingChargeReceiptId { get; set; }
        public string SalesInvoiceDiscountDescription { get; set; }
        public bool? SalesCashInvoicePrinted { get; set; }
        public string SalesInvoiceFileCode { get; set; }
        public string SalesCashInvoiceCancelledBy { get; set; }
        public DateTime? SalesCashInvoiceCancelledDate { get; set; }
        public string SalesCashInvoiceAddedBy { get; set; }
        public DateTime? SalesCashInvoiceAddedWhen { get; set; }
        public string SalesCashInvoiceUpdatedBy { get; set; }
        public DateTime? SalesCashInvoiceUpdatedWhen { get; set; }

        public virtual CashCustomer CashCustomer { get; set; }
        public virtual SalesPersons SalesPerson { get; set; }
        public virtual ICollection<ChequeRegister> ChequeRegister { get; set; }
        public virtual ICollection<DeliveryNoteMaster> DeliveryNoteMaster { get; set; }
        public virtual ICollection<StoreIssueVoucherMaster> StoreIssueVoucherMaster { get; set; }
    }
}
