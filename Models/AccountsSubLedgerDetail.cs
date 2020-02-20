using System;
using System.Collections.Generic;

namespace Nbn.eCommenrce.ItemService.Models
{
    public partial class AccountsSubLedgerDetail
    {
        public int AccountsSubLedgerDetailId { get; set; }
        public int? RefId { get; set; }
        public DateTime? RefDate { get; set; }
        public int? RefDetailId { get; set; }
        public int? VoucherTypeId { get; set; }
        public int? SubLedgerAccountId { get; set; }
        public int? SubLedgerAccountTypeId { get; set; }
        public int? AccountCostCentreId { get; set; }
        public decimal? AccountsSubLedgerDetailDebitAmount { get; set; }
        public decimal? AccountsSubLedgerDetailCreditAmount { get; set; }
        public bool? AccountsSubLedgerDetailEntryForCancel { get; set; }
        public string AccountsSubLedgerDetailAddedBy { get; set; }
        public DateTime? AccountsSubLedgerDetailAddedWhen { get; set; }
        public string AccountsSubLedgerDetailUpdatedBy { get; set; }
        public DateTime? AccountsSubLedgerDetailUpdatedWhen { get; set; }

        public virtual AccountCostCentre AccountCostCentre { get; set; }
        public virtual SubLedgerAccountType SubLedgerAccountType { get; set; }
        public virtual VoucherType VoucherType { get; set; }
    }
}
