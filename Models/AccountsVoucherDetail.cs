using System;
using System.Collections.Generic;

namespace Nbn.eCommenrce.ItemService.Models
{
    public partial class AccountsVoucherDetail
    {
        public AccountsVoucherDetail()
        {
            ChequeRegisterNavigation = new HashSet<ChequeRegister>();
        }

        public int VoucherDetailId { get; set; }
        public int VoucherId { get; set; }
        public int LedgerAccountId { get; set; }
        public int? AccountCostCentreId { get; set; }
        public int? SubLedgerAccountTypeId { get; set; }
        public int? SubLedgerAccountId { get; set; }
        public int? ChequeRegisterId { get; set; }
        public int? Crid { get; set; }
        public string VoucherDetailDescription { get; set; }
        public decimal? VoucherDetailDebitAmount { get; set; }
        public decimal? VoucherDetailCreditAmount { get; set; }
        public string VoucherDetaiAddedBy { get; set; }
        public DateTime? VoucherDetaiAddedWhen { get; set; }
        public string VoucherDetaiUpdatedBy { get; set; }
        public DateTime? VoucherDetailUpdatedWhen { get; set; }

        public virtual AccountCostCentre AccountCostCentre { get; set; }
        public virtual ChequeRegister ChequeRegister { get; set; }
        public virtual LedgerAccounts LedgerAccount { get; set; }
        public virtual SubLedgerAccountType SubLedgerAccountType { get; set; }
        public virtual AccountsVoucherMaster Voucher { get; set; }
        public virtual ICollection<ChequeRegister> ChequeRegisterNavigation { get; set; }
    }
}
