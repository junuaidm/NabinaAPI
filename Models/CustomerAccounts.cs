using System;
using System.Collections.Generic;

namespace Nbn.eCommenrce.ItemService.Models
{
    public partial class CustomerAccounts
    {
        public CustomerAccounts()
        {
            SalesQuotation = new HashSet<SalesQuotation>();
            StoreIssueVoucherMaster = new HashSet<StoreIssueVoucherMaster>();
        }

        public int CustAccntId { get; set; }
        public int? CustomerId { get; set; }
        public string CustAccntName { get; set; }
        public string CustAccntNo { get; set; }
        public string CustAccntDesc { get; set; }
        public DateTime? CustAccntDate { get; set; }
        public bool? CustAccntIsActive { get; set; }
        public bool? CustAccntIsDefault { get; set; }
        public string CustAccntAddedBy { get; set; }
        public DateTime? CustAccntAddedWhen { get; set; }
        public string CustAccntUpdatedBy { get; set; }
        public DateTime? CustAccntUpdatedWhen { get; set; }

        public virtual CustomerMaster Customer { get; set; }
        public virtual ICollection<SalesQuotation> SalesQuotation { get; set; }
        public virtual ICollection<StoreIssueVoucherMaster> StoreIssueVoucherMaster { get; set; }
    }
}
