using System;
using System.Collections.Generic;

namespace Nbn.eCommenrce.ItemService.Models
{
    public partial class SrmreturnedItems
    {
        public int SrmreturnItemId { get; set; }
        public int? Srmid { get; set; }
        public int? SivdetailId { get; set; }
        public int? ItemId { get; set; }
        public int? ItemClassId { get; set; }
        public int? UnitId { get; set; }
        public decimal? ItemActualStock { get; set; }
        public decimal? ItemGroundStock { get; set; }
        public int? BaseUnitId { get; set; }
        public decimal? BaseUnitQty { get; set; }
        public decimal? BaseUnitCost { get; set; }
        public int? SrcdetailId { get; set; }
        public decimal? SrmreturnItemQty { get; set; }
        public decimal? SrmreturnItemActualQty { get; set; }
        public decimal? SrmreturnItemPrice { get; set; }
        public decimal? SrmreturnItemUnitPrice { get; set; }
        public decimal? SrmreturnItemCost { get; set; }
        public decimal? SrmreturnItemDiscount { get; set; }
        public decimal? SrmreturnItemDiscountAmount { get; set; }
        public decimal? SrmreturnItemNetAmount { get; set; }
        public string SrmreturnItemDescArabic { get; set; }
        public string SrmreturnAddedBy { get; set; }
        public DateTime? SrmreturnAddedWhen { get; set; }
        public string SrmreturnUpdatedBy { get; set; }
        public DateTime? SrmreturnUpdatedWhen { get; set; }

        public virtual Items Item { get; set; }
        public virtual Srmmaster Srm { get; set; }
    }
}
