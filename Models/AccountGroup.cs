using System;
using System.Collections.Generic;

namespace Nbn.eCommenrce.ItemService.Models
{
    public partial class AccountGroup
    {
        public AccountGroup()
        {
            LedgerAccounts = new HashSet<LedgerAccounts>();
        }

        public int AccountGroupId { get; set; }
        public int? AccountTypeId { get; set; }
        public string AccountGroupName { get; set; }
        public string AccountGroupCode { get; set; }
        public int? AccountGroupParentId { get; set; }
        public int? AccountGroupSortOrder { get; set; }
        public string AccountGroupDescription { get; set; }
        public string AccountGroupNonEditable { get; set; }
        public string AccountGroupAddedBy { get; set; }
        public DateTime? AccountGroupAddedWhen { get; set; }
        public string AccountGroupUpdatedBy { get; set; }
        public DateTime? AccountGroupUpdatedWhen { get; set; }

        public virtual AccountType AccountType { get; set; }
        public virtual ICollection<LedgerAccounts> LedgerAccounts { get; set; }
    }
}
