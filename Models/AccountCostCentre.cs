using System;
using System.Collections.Generic;

namespace Nbn.eCommenrce.ItemService.Models
{
    public partial class AccountCostCentre
    {
        public AccountCostCentre()
        {
            AccountsLedgerDetail = new HashSet<AccountsLedgerDetail>();
            AccountsSubLedgerDetail = new HashSet<AccountsSubLedgerDetail>();
            AccountsVoucherDetail = new HashSet<AccountsVoucherDetail>();
        }

        public int AccountCostCentreId { get; set; }
        public string AccountCostCentreName { get; set; }
        public int? AccountCostCentreParent { get; set; }
        public bool? AccountCostCentreIsActive { get; set; }
        public string AccountCostCentreDescription { get; set; }
        public string AccountCostCentreAddedBy { get; set; }
        public DateTime? AccountCostCentreAddedWhen { get; set; }
        public string AccountCostCentreUpdatedBy { get; set; }
        public DateTime? AccountCostCentreUpdatedWhen { get; set; }

        public virtual ICollection<AccountsLedgerDetail> AccountsLedgerDetail { get; set; }
        public virtual ICollection<AccountsSubLedgerDetail> AccountsSubLedgerDetail { get; set; }
        public virtual ICollection<AccountsVoucherDetail> AccountsVoucherDetail { get; set; }
    }
}
