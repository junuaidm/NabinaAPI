using System;
using System.Collections.Generic;

namespace Nbn.eCommenrce.ItemService.Models
{
    public partial class CashCustomer
    {
        public CashCustomer()
        {
            ChequeRegister = new HashSet<ChequeRegister>();
            SalesCashInvoiceMaster = new HashSet<SalesCashInvoiceMaster>();
            SalesQuotation = new HashSet<SalesQuotation>();
            SalesReceiptMaster = new HashSet<SalesReceiptMaster>();
            StoreIssueVoucherMaster = new HashSet<StoreIssueVoucherMaster>();
        }

        public int CashCustomerId { get; set; }
        public string CashCustomerName { get; set; }
        public string CashCustomerPobox { get; set; }
        public string CashCustomerAddress1 { get; set; }
        public string CashCustomeraddress2 { get; set; }
        public string CashCustomerTelephone { get; set; }
        public string CashCustomerFax { get; set; }
        public string CashCustomerEmail { get; set; }
        public string CashCustomerContactPersonName { get; set; }
        public string CashCustomerDesignation { get; set; }
        public bool? CashCustomerIsActive { get; set; }
        public string CashCustomerMobile { get; set; }
        public string CashCustomerAddedBy { get; set; }
        public DateTime? CashCustomerAddedWhen { get; set; }
        public string CashCustomerUpdatedBy { get; set; }
        public DateTime? CashCustomerUpdatedWhen { get; set; }

        public virtual ICollection<ChequeRegister> ChequeRegister { get; set; }
        public virtual ICollection<SalesCashInvoiceMaster> SalesCashInvoiceMaster { get; set; }
        public virtual ICollection<SalesQuotation> SalesQuotation { get; set; }
        public virtual ICollection<SalesReceiptMaster> SalesReceiptMaster { get; set; }
        public virtual ICollection<StoreIssueVoucherMaster> StoreIssueVoucherMaster { get; set; }
    }
}
