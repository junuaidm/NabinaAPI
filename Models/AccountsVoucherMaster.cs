using System;
using System.Collections.Generic;

namespace Nbn.eCommenrce.ItemService.Models
{
    public partial class AccountsVoucherMaster
    {
        public AccountsVoucherMaster()
        {
            AccountsVoucherDetail = new HashSet<AccountsVoucherDetail>();
            ChequeRegisterChequeRegisterDepositVoucher = new HashSet<ChequeRegister>();
            ChequeRegisterVoucher = new HashSet<ChequeRegister>();
        }

        public int VoucherId { get; set; }
        public string VoucherCode { get; set; }
        public DateTime? VoucherDate { get; set; }
        public DateTime? VoucherEffectiveDate { get; set; }
        public int? VoucherTypeId { get; set; }
        public string VoucherReference { get; set; }
        public string VoucherDescription { get; set; }
        public string VoucherGrantee { get; set; }
        public decimal? VoucherAmount { get; set; }
        public string VoucherChequeNo { get; set; }
        public DateTime? VoucherChequeDate { get; set; }
        public string VoucherBankName { get; set; }
        public int? VoucherStatus { get; set; }
        public int? VoucherChequeDepositVoucherId { get; set; }
        public int? LedgerAccountId { get; set; }
        public int? SubLedgerAccountTypeId { get; set; }
        public int? SubLedgerAccountId { get; set; }
        public string VoucherAddedBy { get; set; }
        public DateTime? VoucherAddedWhen { get; set; }
        public string VoucherUpdatedBy { get; set; }
        public DateTime? VoucherUpdatedWhen { get; set; }

        public virtual VoucherType VoucherType { get; set; }
        public virtual ICollection<AccountsVoucherDetail> AccountsVoucherDetail { get; set; }
        public virtual ICollection<ChequeRegister> ChequeRegisterChequeRegisterDepositVoucher { get; set; }
        public virtual ICollection<ChequeRegister> ChequeRegisterVoucher { get; set; }
    }
}
