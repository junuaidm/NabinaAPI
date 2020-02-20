using System;
using System.Collections.Generic;

namespace Nbn.eCommenrce.ItemService.Models
{
    public partial class ItemPriceLog
    {
        public int ItemPriceLogId { get; set; }
        public int? ItemId { get; set; }
        public decimal? ItemOldCost { get; set; }
        public decimal? ItemCost { get; set; }
        public decimal? RawMaterialCost { get; set; }
        public decimal? RawMaterialOldCost { get; set; }
        public string ItemCostModifiedBy { get; set; }
        public decimal? OldSellingPriceFactor { get; set; }
        public decimal? SellingPriceFactor { get; set; }
        public decimal? OldLabourFactor { get; set; }
        public decimal? LabourFactor { get; set; }
        public decimal? ItemOldSellingPrice { get; set; }
        public decimal? ItemSellingPrice { get; set; }
        public string ItemSellingPriceModifiedBy { get; set; }
        public int? PricingSchemeId { get; set; }
        public decimal? PricingOldPrice { get; set; }
        public decimal? PricingNewPrice { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedWhen { get; set; }
    }
}
