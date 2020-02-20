using System;
using System.Collections.Generic;

namespace Nbn.eCommenrce.ItemService.Models
{
    public partial class Memmaster
    {
        public Memmaster()
        {
            DeliveryNoteMaster = new HashSet<DeliveryNoteMaster>();
            MemitemsIssued = new HashSet<MemitemsIssued>();
            StoreIssueVoucherMaster = new HashSet<StoreIssueVoucherMaster>();
        }

        public int Memid { get; set; }
        public string Memcode { get; set; }
        public int? Memtype { get; set; }
        public int? Sivid { get; set; }
        public int? Srcid { get; set; }
        public int? SalesPersonId { get; set; }
        public int? CustomerId { get; set; }
        public int? CashCustomerId { get; set; }
        public int? CustAccntId { get; set; }
        public int? SalesCashInvoiceId { get; set; }
        public int? SalesCreditInvoiceId { get; set; }
        public int? SalesSampleInvoiceId { get; set; }
        public int? SalesMockupInvoiceId { get; set; }
        public DateTime? Memdate { get; set; }
        public string Memreason { get; set; }
        public string Memremarks { get; set; }
        public int? Memstatus { get; set; }
        public bool? MemisPrinted { get; set; }
        public decimal? MemtotalReturnedAmount { get; set; }
        public decimal? MemtotalAmountIssued { get; set; }
        public decimal? MemtotalDiscountPercentageIssued { get; set; }
        public decimal? MemtotalDiscountAmountIssued { get; set; }
        public decimal? MemtotalNetAmountIssued { get; set; }
        public decimal? MemtotalDeliveryCharge { get; set; }
        public decimal? MembankCharge { get; set; }
        public decimal? MemtotalFixingCharge { get; set; }
        public string MemaddedBy { get; set; }
        public DateTime? MemaddedWhen { get; set; }
        public string MemupdatedBy { get; set; }
        public DateTime? MemupdatedWhen { get; set; }

        public virtual StoreIssueVoucherMaster Siv { get; set; }
        public virtual SalesReturnConfirmationMaster Src { get; set; }
        public virtual ICollection<DeliveryNoteMaster> DeliveryNoteMaster { get; set; }
        public virtual ICollection<MemitemsIssued> MemitemsIssued { get; set; }
        public virtual ICollection<StoreIssueVoucherMaster> StoreIssueVoucherMaster { get; set; }
    }
}
