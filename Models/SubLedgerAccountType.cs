using System;
using System.Collections.Generic;

namespace Nbn.eCommenrce.ItemService.Models
{
    public partial class SubLedgerAccountType
    {
        public SubLedgerAccountType()
        {
            AccountsSubLedgerDetail = new HashSet<AccountsSubLedgerDetail>();
            AccountsVoucherDetail = new HashSet<AccountsVoucherDetail>();
            ChequeRegister = new HashSet<ChequeRegister>();
        }

        public int SubLedgerAccountTypeId { get; set; }
        public string SubLedgerAccountTypeName { get; set; }
        public bool? SubLedgerAccountTypeIsActive { get; set; }
        public string SubLedgerAccountTypeDescription { get; set; }
        public bool? SubLedgerAccountTypeIsAssetCategory { get; set; }
        public bool? SubLedgerAccountTypeCanBeUsedForAccntTransaction { get; set; }
        public string SubLedgerAccountTypeAddedBy { get; set; }
        public DateTime? SubLedgerAccountTypeAddedWhen { get; set; }
        public string SubLedgerAccountTypeUpdatedBy { get; set; }
        public DateTime? SubLedgerAccountTypeUpdatedWhen { get; set; }

        public virtual ICollection<AccountsSubLedgerDetail> AccountsSubLedgerDetail { get; set; }
        public virtual ICollection<AccountsVoucherDetail> AccountsVoucherDetail { get; set; }
        public virtual ICollection<ChequeRegister> ChequeRegister { get; set; }
    }
}
