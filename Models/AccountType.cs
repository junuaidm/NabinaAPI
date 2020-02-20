using System;
using System.Collections.Generic;

namespace Nbn.eCommenrce.ItemService.Models
{
    public partial class AccountType
    {
        public AccountType()
        {
            AccountGroup = new HashSet<AccountGroup>();
        }

        public int AccountTypeId { get; set; }
        public string AccountTypeCode { get; set; }
        public string AccountTypeName { get; set; }
        public int? AccountTypeSortOrder { get; set; }

        public virtual ICollection<AccountGroup> AccountGroup { get; set; }
    }
}
