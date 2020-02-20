using System;
using System.Collections.Generic;

namespace Nbn.eCommenrce.ItemService.Models
{
    public partial class ChequeRegister
    {
        public ChequeRegister()
        {
            AccountsVoucherDetail = new HashSet<AccountsVoucherDetail>();
        }

        public int ChequeRegisterId { get; set; }
        public DateTime? ChequeRegisterDate { get; set; }
        public int? SubLedgerAccountTypeId { get; set; }
        public int? SubLedgerAccountId { get; set; }
        public int? LedgerAccountId { get; set; }
        public int? CashCustomerId { get; set; }
        public int? VoucherId { get; set; }
        public int? SalesCashInvoiceId { get; set; }
        public int? SalesReceiptId { get; set; }
        public decimal? ChequeRegisterChequeAmount { get; set; }
        public string ChequeRegisterChequeType { get; set; }
        public string ChequeRegisterChequeNo { get; set; }
        public DateTime? ChequeRegisterChequeDate { get; set; }
        public string ChequeRegisterChequeBankName { get; set; }
        public bool? ChequeRegisterChequeIsDeposited { get; set; }
        public DateTime? ChequeRegisterChequeDepositedDate { get; set; }
        public bool? ChequeRegisterChequeIsCleared { get; set; }
        public DateTime? ChequeRegisterChequeClearedDate { get; set; }
        public bool? ChequeRegisterChequeIsBounced { get; set; }
        public DateTime? ChequeRegisterChequeBouncedDate { get; set; }
        public bool? ChequeRegisterChequeIsGivenBack { get; set; }
        public DateTime? ChequeRegisterChequeGivenBackDate { get; set; }
        public int? ChequeRegisterChequeStatus { get; set; }
        public int? ChequeRegisterDepositVoucherId { get; set; }
        public int? ChequeRegisterDepositVoucherDetailId { get; set; }
        public DateTime? ChequeRegisterChequePostPonedDate { get; set; }
        public string ChequeRegisterChequeAddedBy { get; set; }
        public DateTime? ChequeRegisterChequeAddedWhen { get; set; }
        public string ChequeRegisterChequeUpdatedBy { get; set; }
        public DateTime? ChequeRegisterChequeUpdatedWhen { get; set; }

        public virtual CashCustomer CashCustomer { get; set; }
        public virtual AccountsVoucherMaster ChequeRegisterDepositVoucher { get; set; }
        public virtual AccountsVoucherDetail ChequeRegisterDepositVoucherDetail { get; set; }
        public virtual LedgerAccounts LedgerAccount { get; set; }
        public virtual SalesCashInvoiceMaster SalesCashInvoice { get; set; }
        public virtual SalesReceiptMaster SalesReceipt { get; set; }
        public virtual SubLedgerAccountType SubLedgerAccountType { get; set; }
        public virtual AccountsVoucherMaster Voucher { get; set; }
        public virtual ICollection<AccountsVoucherDetail> AccountsVoucherDetail { get; set; }
    }
}
