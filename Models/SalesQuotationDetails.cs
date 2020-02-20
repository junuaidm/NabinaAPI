using System;
using System.Collections.Generic;

namespace Nbn.eCommenrce.ItemService.Models
{
    public partial class SalesQuotationDetails
    {
        public int SqdetailId { get; set; }
        public int? SalesQuoteId { get; set; }
        public int? SetId { get; set; }
        public int? IsdetailId { get; set; }
        public int? ItemId { get; set; }
        public string ItemDescription { get; set; }
        public int? PricingId { get; set; }
        public int? UnitId { get; set; }
        public int? ItemImgId { get; set; }
        public int? ParentSqdetailId { get; set; }
        public int? SqdetailBaseUnitId { get; set; }
        public decimal? SqdetailBaseUnitQty { get; set; }
        public decimal? SqdetailItemSetQty { get; set; }
        public decimal? SqdetailItemQty { get; set; }
        public decimal? SqdetailItemActualQty { get; set; }
        public decimal? SqdetailItemCost { get; set; }
        public decimal? SqdetailItemPrice { get; set; }
        public decimal? SqdetailItemDiscountPercentage { get; set; }
        public decimal? SqdetailItemDiscountAmount { get; set; }
        public decimal? SqdetailItemNetRate { get; set; }
        public decimal? SqdetailItemNetAmount { get; set; }
        public int? SqdetailSerialNo { get; set; }
        public string SqdetailAddedBy { get; set; }
        public DateTime? SqdetailAddedWhen { get; set; }
        public string SqdetailUpdatedBy { get; set; }
        public DateTime? SqdetailUpdatedWhen { get; set; }

        public virtual ItemSetDetails Isdetail { get; set; }
        public virtual Items Item { get; set; }
        public virtual ItemImages ItemImg { get; set; }
        public virtual ItemPricing Pricing { get; set; }
        public virtual SalesQuotation SalesQuote { get; set; }
        public virtual ItemSets Set { get; set; }
        public virtual Units Unit { get; set; }
    }
}
