using System;
using System.Collections.Generic;

namespace Nbn.eCommenrce.ItemService.Models
{
    public partial class AccountsLedgerDetailOld
    {
        public int AccountsLedgerDetailId { get; set; }
        public int? RefId { get; set; }
        public DateTime? RefDate { get; set; }
        public int? VoucherTypeId { get; set; }
        public int? LedgerAccountId { get; set; }
        public int? AccountCostCentreId { get; set; }
        public decimal? AccountsLedgerDetailDebitAmount { get; set; }
        public decimal? AccountsLedgerDetailCreditAmount { get; set; }
        public string AccountsLedgerDetailAddedBy { get; set; }
        public DateTime? AccountsLedgerDetailAddedWhen { get; set; }
        public string AccountsLedgerDetailUpdatedBy { get; set; }
        public DateTime? AccountsLedgerDetailUpdatedWhen { get; set; }
    }
}
