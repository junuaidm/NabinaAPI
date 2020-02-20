using System;
using System.Collections.Generic;

namespace Nbn.eCommenrce.ItemService.Models
{
    public partial class MemitemsIssued
    {
        public int MemitemIssuedId { get; set; }
        public int? MemitemIssuedSerialNo { get; set; }
        public int? Memid { get; set; }
        public int? ItemId { get; set; }
        public int? ItemClassId { get; set; }
        public int? IsdetailId { get; set; }
        public int? SetId { get; set; }
        public int? PricingId { get; set; }
        public int? UnitId { get; set; }
        public int? ItemImgId { get; set; }
        public string ItemDescription { get; set; }
        public string ItemDescriptionArabic { get; set; }
        public decimal? ItemActualStock { get; set; }
        public decimal? ItemGroundStock { get; set; }
        public decimal? MemitemIssuedSetQty { get; set; }
        public decimal? MemitemIssuedQty { get; set; }
        public decimal? MemitemIssuedActualQty { get; set; }
        public int? BaseUnitId { get; set; }
        public decimal? BaseUnitQty { get; set; }
        public decimal? BaseUnitCost { get; set; }
        public decimal? MemitemIssuedUnitPrice { get; set; }
        public decimal? MemitemIssuedItemPrice { get; set; }
        public decimal? MemitemIssuedItemCost { get; set; }
        public decimal? MemitemIssuedDiscountPercentage { get; set; }
        public decimal? MemitemIssuedDiscountAmount { get; set; }
        public decimal? MemitemIssuedNetRate { get; set; }
        public decimal? MemitemIssuedNetAmount { get; set; }
        public string MemitemIssuedAddedBy { get; set; }
        public DateTime? MemitemIssuedAddedWhen { get; set; }
        public string MemitemIssuedUpdatedBy { get; set; }
        public DateTime? MemitemIssuedUpdatedWhen { get; set; }

        public virtual Items Item { get; set; }
        public virtual Memmaster Mem { get; set; }
    }
}
