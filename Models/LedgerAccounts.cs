using System;
using System.Collections.Generic;

namespace Nbn.eCommenrce.ItemService.Models
{
    public partial class LedgerAccounts
    {
        public LedgerAccounts()
        {
            AccountsLedgerDetail = new HashSet<AccountsLedgerDetail>();
            AccountsVoucherDetail = new HashSet<AccountsVoucherDetail>();
            ChequeRegister = new HashSet<ChequeRegister>();
        }

        public int LedgerAccountId { get; set; }
        public int? AccountgroupId { get; set; }
        public string LedgerAccountNumber { get; set; }
        public string LedgerAccountName { get; set; }
        public string LedgerAccountDescription { get; set; }
        public decimal? OpeningBalance { get; set; }
        public string OpeningBalanceType { get; set; }
        public DateTime? OpeningBalanceDate { get; set; }
        public bool? LedgerAccountIsActive { get; set; }
        public int? LedgerAccountSortOrder { get; set; }
        public bool? LedgerAccountHasSubLedger { get; set; }
        public int? SubledgerAccountTypeId { get; set; }
        public string LedgerAccountAddedBy { get; set; }
        public DateTime? LedgerAccountAddedWhen { get; set; }
        public string LedgerAccountUpdatedBy { get; set; }
        public DateTime? LedgerAccountUpdatedWhen { get; set; }

        public virtual AccountGroup Accountgroup { get; set; }
        public virtual ICollection<AccountsLedgerDetail> AccountsLedgerDetail { get; set; }
        public virtual ICollection<AccountsVoucherDetail> AccountsVoucherDetail { get; set; }
        public virtual ICollection<ChequeRegister> ChequeRegister { get; set; }
    }
}
