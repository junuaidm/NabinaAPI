using System;
using System.Collections.Generic;

namespace Nbn.eCommenrce.ItemService.Models
{
    public partial class CustomerBalanceMaster
    {
        public int CustomerBalanceId { get; set; }
        public DateTime? CustomerBalanceDate { get; set; }
        public decimal? CustomerBalanceAmount { get; set; }
        public string CustomerBalanceAmountType { get; set; }
        public int? SalesCreditInvoiceId { get; set; }
        public int? VoucherId { get; set; }
        public int? Srmid { get; set; }
        public int? ReceiptId { get; set; }
        public int? CustomerId { get; set; }
        public int? CustAccntId { get; set; }
        public int? CustomerBalanceStatus { get; set; }
        public string CustomerBalanceAddedBy { get; set; }
        public DateTime? CustomerBalanceAddedWhen { get; set; }
        public string CustomerBalanceUpdatedBy { get; set; }
        public DateTime? CustomerBalanceUpdatedWhen { get; set; }
    }
}
