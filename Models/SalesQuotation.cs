using System;
using System.Collections.Generic;

namespace Nbn.eCommenrce.ItemService.Models
{
    public partial class SalesQuotation
    {
        public SalesQuotation()
        {
            SalesQuotationDetails = new HashSet<SalesQuotationDetails>();
            SalesQuotationDocuments = new HashSet<SalesQuotationDocuments>();
            SqdeliveryAddress = new HashSet<SqdeliveryAddress>();
        }

        public int SalesQuoteId { get; set; }
        public string SalesQuoteCode { get; set; }
        public int? SalesQuoteRevisionNo { get; set; }
        public int? CustomerId { get; set; }
        public int? CustAccntId { get; set; }
        public int? CashCustomerId { get; set; }
        public int? ContactDetId { get; set; }
        public int? ProjectId { get; set; }
        public int? CustEnquiryId { get; set; }
        public int? SalesPersonId { get; set; }
        public int? SalesQuoteTypeId { get; set; }
        public string SalesQuoteFrom { get; set; }
        public string SalesQuoteInvoiceType { get; set; }
        public string SalesQuoteOurReference { get; set; }
        public string SalesQuoteCustomerReference { get; set; }
        public string SalesQuoteDescription { get; set; }
        public int? DeliveryTermsId { get; set; }
        public int? DeliveryTimeId { get; set; }
        public int? PaymentTermsId { get; set; }
        public int? PriceValidityId { get; set; }
        public int? TermsId { get; set; }
        public int? ParentSalesQuoteId { get; set; }
        public bool? SalesQuoteStockReservation { get; set; }
        public DateTime? SalesQuoteStockReservationExpiryDate { get; set; }
        public string SalesQuoteSubject { get; set; }
        public DateTime? SalesQuoteApprovalDate { get; set; }
        public int? SalesQuoteStatus { get; set; }
        public string SalesQuoteNotes { get; set; }
        public int? SalesQuoteDiscountType { get; set; }
        public decimal? SalesQuoteTotalAmount { get; set; }
        public decimal? SalesQuoteTotalDiscountPercent { get; set; }
        public decimal? SalesQuoteTotalDiscountAmount { get; set; }
        public decimal? SalesQuoteTaxPercent { get; set; }
        public decimal? SalesQuoteTaxAmount { get; set; }
        public decimal? SalesQuoteTotalFixing { get; set; }
        public decimal? SalesQuoteTotalBankCharge { get; set; }
        public decimal? SalesQuoteTotalDiscountOnDelivery { get; set; }
        public decimal? SalesQuoteTotalNetAmount { get; set; }
        public string SalesQuoteDiscountDescription { get; set; }
        public decimal? SalesQuoteNoOfUnits { get; set; }
        public int? InvoiceItemCategoryId { get; set; }
        public bool? SalesQuoteIsDeliveryOnly { get; set; }
        public bool? SalesQuoteIsDeliveryAndInstallation { get; set; }
        public string SalesQuoteAddedBy { get; set; }
        public DateTime? SalesQuoteAddedWhen { get; set; }
        public string SalesQuoteUpdatedBy { get; set; }
        public DateTime? SalesQuoteUpdatedWhen { get; set; }
        public int? DrawingChargeReceiptId { get; set; }
        public decimal? DrawingChargeDiscountAmount { get; set; }

        public virtual CashCustomer CashCustomer { get; set; }
        public virtual CustomerContactDetails ContactDet { get; set; }
        public virtual CustomerAccounts CustAccnt { get; set; }
        public virtual CustomerEnquiries CustEnquiry { get; set; }
        public virtual CustomerMaster Customer { get; set; }
        public virtual SalesDeliveryTerms DeliveryTerms { get; set; }
        public virtual SalesDeliveryTime DeliveryTime { get; set; }
        public virtual SalesPaymentTerms PaymentTerms { get; set; }
        public virtual SalesPriceValidity PriceValidity { get; set; }
        public virtual Projects Project { get; set; }
        public virtual SalesPersons SalesPerson { get; set; }
        public virtual SalesQuotationType SalesQuoteType { get; set; }
        public virtual TermsAndConditions Terms { get; set; }
        public virtual ICollection<SalesQuotationDetails> SalesQuotationDetails { get; set; }
        public virtual ICollection<SalesQuotationDocuments> SalesQuotationDocuments { get; set; }
        public virtual ICollection<SqdeliveryAddress> SqdeliveryAddress { get; set; }
    }
}
