using System;
using System.Collections.Generic;

namespace Nbn.eCommenrce.ItemService.Models
{
    public partial class LedgerSubAccounts
    {
        public int LedgerSubAccountId { get; set; }
        public string LedgerSubAccountNumber { get; set; }
        public string LedgerSubAccountName { get; set; }
        public int LedgerAccountId { get; set; }
        public bool? LedgerSubAccountIsActive { get; set; }
        public string LedgerSubAccountAddedBy { get; set; }
        public DateTime? LedgerSubAccountAddedWhen { get; set; }
        public string LedgerSubAccountUpdatedBy { get; set; }
        public DateTime? LedgerSubAccountUpdatedWhen { get; set; }
    }
}
