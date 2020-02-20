using System;
using System.Collections.Generic;

namespace Nbn.eCommenrce.ItemService.Models
{
    public partial class SalesReceiptMaster
    {
        public SalesReceiptMaster()
        {
            ChequeRegister = new HashSet<ChequeRegister>();
        }

        public int SalesReceiptId { get; set; }
        public string SalesReceiptCode { get; set; }
        public DateTime? SalesReceiptDate { get; set; }
        public int? CustomerId { get; set; }
        public int? CustAccntId { get; set; }
        public int? CashCustomerId { get; set; }
        public bool? IsReceiptForDrawingCharges { get; set; }
        public string DrawingCustomerName { get; set; }
        public string DrawingCustomerAddress { get; set; }
        public string SalesReceiptDescription { get; set; }
        public decimal? SalesReceiptAmount { get; set; }
        public string SalesReceiptType { get; set; }
        public string SalesReceiptPaymentMode { get; set; }
        public string SalesReceiptChequeNo { get; set; }
        public DateTime? SalesReceiptChequeDated { get; set; }
        public string SalesReceiptBankName { get; set; }
        public string SalesReceiptCardNo { get; set; }
        public int? SalesReceiptCardId { get; set; }
        public int? SalesPersonId { get; set; }
        public int? SalesReceiptBankId { get; set; }
        public int? SalesReceiptStatus { get; set; }
        public bool? SalesReceiptIsCancelled { get; set; }
        public bool? SalesReceiptIsValid { get; set; }
        public string SalesReceiptNotes { get; set; }
        public int? BillCollectorId { get; set; }
        public string SalesReceiptAddedBy { get; set; }
        public DateTime? SalesReceiptAddedWhen { get; set; }
        public string SalesReceiptUpdatedBy { get; set; }
        public DateTime? SalesReceiptUpdatedWhen { get; set; }

        public virtual CashCustomer CashCustomer { get; set; }
        public virtual ICollection<ChequeRegister> ChequeRegister { get; set; }
    }
}
