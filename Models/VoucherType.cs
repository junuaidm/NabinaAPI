using System;
using System.Collections.Generic;

namespace Nbn.eCommenrce.ItemService.Models
{
    public partial class VoucherType
    {
        public VoucherType()
        {
            AccountsLedgerDetail = new HashSet<AccountsLedgerDetail>();
            AccountsSubLedgerDetail = new HashSet<AccountsSubLedgerDetail>();
            AccountsVoucherMaster = new HashSet<AccountsVoucherMaster>();
        }

        public int VoucherTypeId { get; set; }
        public int? VoucherTypeParentId { get; set; }
        public string VoucherTypeName { get; set; }
        public string VoucherTypeAbbreviation { get; set; }
        public string VoucherTypeDescription { get; set; }
        public bool? VoucherTypeNonEditable { get; set; }
        public bool? VoucherTypeCanUseForTransaction { get; set; }
        public string VoucherTypeAddedBy { get; set; }
        public DateTime? VoucherTypeAddedWhen { get; set; }
        public string VoucherTypeUpdatedBy { get; set; }
        public DateTime? VoucherTypeUpdatedWhen { get; set; }

        public virtual ICollection<AccountsLedgerDetail> AccountsLedgerDetail { get; set; }
        public virtual ICollection<AccountsSubLedgerDetail> AccountsSubLedgerDetail { get; set; }
        public virtual ICollection<AccountsVoucherMaster> AccountsVoucherMaster { get; set; }
    }
}
