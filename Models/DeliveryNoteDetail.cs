using System;
using System.Collections.Generic;

namespace Nbn.eCommenrce.ItemService.Models
{
    public partial class DeliveryNoteDetail
    {
        public int DndetailId { get; set; }
        public int? DeliveryNoteId { get; set; }
        public int? SivdetailId { get; set; }
        public int? SlcashInvoiceDetailId { get; set; }
        public int? SlcreditInvoiceDetailId { get; set; }
        public int? SlmockupInvoiceDetailId { get; set; }
        public int? SlsampleInvoiceDetailId { get; set; }
        public int? MemitemIssuedId { get; set; }
        public int? ItemId { get; set; }
        public int? UnitId { get; set; }
        public decimal? ItemCost { get; set; }
        public decimal? ItemActualStock { get; set; }
        public decimal? ItemGroundStock { get; set; }
        public decimal? DnitemQty { get; set; }
        public decimal? DnitemActualQty { get; set; }
        public int? BaseUnitId { get; set; }
        public decimal? BaseUnitQty { get; set; }
        public decimal? BaseUnitCost { get; set; }
        public string DndetailsAddedBy { get; set; }
        public DateTime? DndetailsAddedWhen { get; set; }
        public string DndetailsUpdatedBy { get; set; }
        public DateTime? DndetailsUpdatedWhen { get; set; }

        public virtual DeliveryNoteMaster DeliveryNote { get; set; }
        public virtual Items Item { get; set; }
        public virtual StoreIssueVoucherDetail Sivdetail { get; set; }
        public virtual Units Unit { get; set; }
    }
}
