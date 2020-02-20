using System;
using System.Collections.Generic;

namespace Nbn.eCommenrce.ItemService.Models
{
    public partial class DeliveryNoteItemDetail
    {
        public int DnitemDetailId { get; set; }
        public int? DndetailId { get; set; }
        public int? DeliveryNoteId { get; set; }
        public int? ItemId { get; set; }
        public int? UnitId { get; set; }
        public int? StorageAreaId { get; set; }
        public decimal? DnitemDetailsDeliveryQty { get; set; }
        public decimal? DnitemDetailsQtyBeforeDelivery { get; set; }
        public int? BaseUnitId { get; set; }
        public decimal? BaseUnitQty { get; set; }
        public string DnitemDetailsAddedBy { get; set; }
        public DateTime? DnitemDetailsAddedWhen { get; set; }
        public string DnitemDetailsUpdatedBy { get; set; }
        public DateTime? DnitemDetailsUpdatedWhen { get; set; }

        public virtual Units BaseUnit { get; set; }
        public virtual DeliveryNoteMaster DeliveryNote { get; set; }
        public virtual Items Item { get; set; }
        public virtual WhWareHouseStorageArea StorageArea { get; set; }
        public virtual Units Unit { get; set; }
    }
}
