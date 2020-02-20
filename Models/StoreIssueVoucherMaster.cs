using System;
using System.Collections.Generic;

namespace Nbn.eCommenrce.ItemService.Models
{
    public partial class StoreIssueVoucherMaster
    {
        public StoreIssueVoucherMaster()
        {
            DeliveryNoteMaster = new HashSet<DeliveryNoteMaster>();
            Memmaster = new HashSet<Memmaster>();
            SalesReturnConfirmationMaster = new HashSet<SalesReturnConfirmationMaster>();
            StoreIssueVoucherDetail = new HashSet<StoreIssueVoucherDetail>();
        }

        public int Sivid { get; set; }
        public DateTime? Sivdate { get; set; }
        public string Sivcode { get; set; }
        public int? SalesCashInvoiceId { get; set; }
        public int? SalesCreditInvoiceId { get; set; }
        public int? SalesSampleInvoiceId { get; set; }
        public int? SalesMockupInvoiceId { get; set; }
        public int? Memid { get; set; }
        public int? CustomerId { get; set; }
        public int? CashCustomerId { get; set; }
        public int? CustAccntId { get; set; }
        public int? Sivstatus { get; set; }
        public bool? SivisPrinted { get; set; }
        public string SivdeliveryLoc { get; set; }
        public string SivcontactPerson { get; set; }
        public string SivdeliveryContactNo { get; set; }
        public string SivaddedBy { get; set; }
        public DateTime? SivaddedWhen { get; set; }
        public string SivupdatedBy { get; set; }
        public DateTime? SivupdatedWhen { get; set; }

        public virtual CashCustomer CashCustomer { get; set; }
        public virtual CustomerAccounts CustAccnt { get; set; }
        public virtual CustomerMaster Customer { get; set; }
        public virtual Memmaster Mem { get; set; }
        public virtual SalesCashInvoiceMaster SalesCashInvoice { get; set; }
        public virtual SalesCreditInvoiceMaster SalesCreditInvoice { get; set; }
        public virtual SalesMockupInvoiceMaster SalesMockupInvoice { get; set; }
        public virtual SalesSampleInvoiceMaster SalesSampleInvoice { get; set; }
        public virtual ICollection<DeliveryNoteMaster> DeliveryNoteMaster { get; set; }
        public virtual ICollection<Memmaster> Memmaster { get; set; }
        public virtual ICollection<SalesReturnConfirmationMaster> SalesReturnConfirmationMaster { get; set; }
        public virtual ICollection<StoreIssueVoucherDetail> StoreIssueVoucherDetail { get; set; }
    }
}
