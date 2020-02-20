using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Nbn.eCommenrce.ItemService.Models
{
    public partial class CustomerMaster
    {
        public CustomerMaster()
        {
            CustomerAccounts = new HashSet<CustomerAccounts>();
            CustomerContactDetails = new HashSet<CustomerContactDetails>();
            CustomerCreditDetails = new HashSet<CustomerCreditDetails>();
            CustomerDocuments = new HashSet<CustomerDocuments>();
            CustomerEnquiries = new HashSet<CustomerEnquiries>();
            CustomerSalesPersons = new HashSet<CustomerSalesPersons>();
            Projects = new HashSet<Projects>();
            SalesQuotation = new HashSet<SalesQuotation>();
            StoreIssueVoucherMaster = new HashSet<StoreIssueVoucherMaster>();
        }
        [Key]
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string CustomerCode { get; set; }
        public string CustomerTitle { get; set; }
        public string CustomerPobox { get; set; }
        public string CustomerCountry { get; set; }
        public int? CustomerType { get; set; }
        public string CustomerAddress1 { get; set; }
        public string CustomerAddress2 { get; set; }
        public string CustomerWebsite { get; set; }
        public string CustomerTelNo { get; set; }
        public string CustomerResidenceNo { get; set; }
        public string CustomerMobileNo { get; set; }
        public string CustomerFaxNo { get; set; }
        public string CustomerEmail { get; set; }
        public string CustomerNatureOfBusiness { get; set; }
        public string CustomerCrno { get; set; }
        public int? CustomerStatus { get; set; }
        public string CustomerRegNo { get; set; }
        public DateTime? CustomerRegExpiry { get; set; }
        public string CustomerOwnerPartner { get; set; }
        public bool? PromotionsCanBeSent { get; set; }
        public bool? IsPartner { get; set; }
        public bool? IsPriorityCustomer { get; set; }
        public decimal? CustomerCreditPeriodAllowed { get; set; }
        public decimal? CreditUtilised { get; set; }
        public decimal? MaximumCreditLimit { get; set; }
        public int? SalesPersonId { get; set; }
        public int? PaymentTermsId { get; set; }
        public int? LedgerAccountId { get; set; }
        public string CustomerNotes { get; set; }
        public bool? IsSearchable { get; set; }
        public bool? IsEditable { get; set; }
        public bool? IsMopchequeGuarantee { get; set; }
        public bool? IsMopletterOfCredit { get; set; }
        public bool? IsMoplocalPurchaseOrder { get; set; }
        public bool? IsMopcreditInvoice { get; set; }
        public bool? IsMoppdcheque { get; set; }
        public bool? IsMopcashCheque { get; set; }
        public string SignatoryAsPerCr { get; set; }
        public decimal? CapitalAsPerCr { get; set; }
        public DateTime? CrexpiryDate { get; set; }
        public string ComputerNo { get; set; }
        public DateTime? GuaranteeChequeDate { get; set; }
        public string Remarks { get; set; }
        public string CustomerAddedBy { get; set; }
        public DateTime? CustomerAddedWhen { get; set; }
        public string CustomerUpdatedBy { get; set; }
        public DateTime? CustomerUpdatedWhen { get; set; }

        public virtual ICollection<CustomerAccounts> CustomerAccounts { get; set; }
        public virtual ICollection<CustomerContactDetails> CustomerContactDetails { get; set; }
        public virtual ICollection<CustomerCreditDetails> CustomerCreditDetails { get; set; }
        public virtual ICollection<CustomerDocuments> CustomerDocuments { get; set; }
        public virtual ICollection<CustomerEnquiries> CustomerEnquiries { get; set; }
        public virtual ICollection<CustomerSalesPersons> CustomerSalesPersons { get; set; }
        public virtual ICollection<Projects> Projects { get; set; }
        public virtual ICollection<SalesQuotation> SalesQuotation { get; set; }
        public virtual ICollection<StoreIssueVoucherMaster> StoreIssueVoucherMaster { get; set; }
    }
}
