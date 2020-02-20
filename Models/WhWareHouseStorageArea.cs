using System;
using System.Collections.Generic;

namespace Nbn.eCommenrce.ItemService.Models
{
    public partial class WhWareHouseStorageArea
    {
        public WhWareHouseStorageArea()
        {
            DeliveryNoteItemDetail = new HashSet<DeliveryNoteItemDetail>();
        }

        public int StorageAreaId { get; set; }
        public string StorageAreaName { get; set; }
        public string StorageAreaCode { get; set; }
        public int? WarehouseId { get; set; }
        public int? ParentStorageArea { get; set; }
        public bool? StorageAreaIsActive { get; set; }
        public decimal? StorageAreaLength { get; set; }
        public decimal? StorageAreaWidth { get; set; }
        public decimal? StorageAreaHeight { get; set; }
        public int? UnitId { get; set; }
        public int? SaitemId { get; set; }
        public string StorageAreaRemarks { get; set; }
        public string StorageAreaAddedBy { get; set; }
        public DateTime? StorageAreaAddedWhen { get; set; }
        public string StorageAreaUpdatedBy { get; set; }
        public DateTime? StorageAreaUpdatedWhen { get; set; }

        public virtual Units Unit { get; set; }
        public virtual ICollection<DeliveryNoteItemDetail> DeliveryNoteItemDetail { get; set; }
    }
}
