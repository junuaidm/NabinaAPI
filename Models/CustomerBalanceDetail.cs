using System;
using System.Collections.Generic;

namespace Nbn.eCommenrce.ItemService.Models
{
    public partial class CustomerBalanceDetail
    {
        public int CustomerBalanceDetailId { get; set; }
        public int? CustomerBalanceId { get; set; }
        public decimal? CustomerBalanceDetailAmount { get; set; }
        public string CustomerBalanceDetailAmountType { get; set; }
        public int? SalesCreditInvoiceId { get; set; }
        public int? VoucherId { get; set; }
        public int? Srmid { get; set; }
        public int? ReceiptId { get; set; }
        public int? Memid { get; set; }
        public int? CustomerBalanceDetailStatus { get; set; }
        public string CustomerBalanceDetailAddedBy { get; set; }
        public DateTime? CustomerBalanceDetailAddedWhen { get; set; }
        public string CustomerBalanceDetailUpdatedBy { get; set; }
        public DateTime? CustomerBalanceDetailUpdatedWhen { get; set; }
    }
}
