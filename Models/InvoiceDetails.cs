using System;
using System.Collections.Generic;

namespace Nbn.eCommenrce.ItemService.Models
{
    public partial class InvoiceDetails
    {
        public long InvDetailId { get; set; }
        public long? InvoiceId { get; set; }
        public int? ItemId { get; set; }
        public decimal? InvDetailQty { get; set; }
        public decimal? InvDetailAdvtPrice { get; set; }
        public int? UnitId { get; set; }
        public decimal? InvDetailTtlDiscount { get; set; }
        public int? AllowDiscountId { get; set; }
        public decimal? InvDetailCost { get; set; }
        public decimal? InvDetailDiscPerItem { get; set; }
        public decimal? InvDetailNewPrice { get; set; }
        public decimal? InvDetailNetAmount { get; set; }
        public decimal? InvDetailActualDisc { get; set; }
        public string InvDetailAddedBy { get; set; }
        public DateTime? InvDetailAddedWhen { get; set; }
        public string InvDetailUpdatedBy { get; set; }
        public DateTime? InvDetailUpdatedWhen { get; set; }
    }
}
