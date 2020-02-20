using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Nbn.eCommenrce.ItemService.Models
{
    public partial class Items
    {
        public Items()
        {
            DeliveryNoteDetail = new HashSet<DeliveryNoteDetail>();
            DeliveryNoteItemDetail = new HashSet<DeliveryNoteItemDetail>();
            ItemAttributes = new HashSet<ItemAttributes>();
            ItemGroupDetails = new HashSet<ItemGroupDetails>();
            ItemPricing = new HashSet<ItemPricing>();
            MemitemsIssued = new HashSet<MemitemsIssued>();
            SalesCashInvoiceDetails = new HashSet<SalesCashInvoiceDetails>();
            SalesMockupInvoiceDetails = new HashSet<SalesMockupInvoiceDetails>();
            SalesQuotationDetails = new HashSet<SalesQuotationDetails>();
            SalesSampleInvoiceDetails = new HashSet<SalesSampleInvoiceDetails>();
            SrmreturnedItems = new HashSet<SrmreturnedItems>();
            StoreIssueVoucherDetail = new HashSet<StoreIssueVoucherDetail>();
        }
        [Key]
        public int ItemId { get; set; }
        public string ItemName { get; set; }
        public string ItemDesc { get; set; }
        public string ItemCode { get; set; }
        public string ItemArtNo { get; set; }
        public int ItemTypeId { get; set; }
        public bool? ItemIsActive { get; set; }
        public int? UnitId { get; set; }
        public decimal? ItemCost { get; set; }
        public decimal? RawMaterialCost { get; set; }
        public decimal? ItemPrice { get; set; }
        public int? SupplierId { get; set; }
        public string ItemRfcode { get; set; }
        public int? ItemClassId { get; set; }
        public decimal? ItemMaxStock { get; set; }
        public decimal? ItemActualStocks { get; set; }
        public decimal? ItemGroundStocks { get; set; }
        public decimal? ItemReservedStocks { get; set; }
        public decimal? ItemSampleStocks { get; set; }
        public decimal? ItemFactoryStocks { get; set; }
        public decimal? ItemGoodsInTransitStocks { get; set; }
        public decimal? ItemMinTransferQty { get; set; }
        public decimal? ItemMaxTransferQty { get; set; }
        public decimal? ItemBalanceQtyToIssue { get; set; }
        public decimal? ItemBalanceQtyToProduce { get; set; }
        public decimal? ItemSellingPriceFactor { get; set; }
        public decimal? ItemLabourFactor { get; set; }
        public decimal? ItemConsumableFactor { get; set; }
        public decimal? ItemReOrderLevel { get; set; }
        public decimal? ItemCriticalLevel { get; set; }
        public string ItemDetDescEng { get; set; }
        public decimal? ItemEconomicOrder { get; set; }
        public string ItemDetDescArabic { get; set; }
        public int? ItemLeadDays { get; set; }
        public decimal? ItemMonthlyDemand { get; set; }
        public decimal? ItemYearlyDemand { get; set; }
        public decimal? ItemMaxValidDiscount { get; set; }
        public decimal? ItemMargin { get; set; }
        public decimal? ItemDefConsumption { get; set; }
        public int? CostCentreId { get; set; }
        public bool? ItemNegativeStockAllowed { get; set; }
        public bool? IsSetItem { get; set; }
        public string ItemCostModifiedBy { get; set; }
        public string ItemSellingPriceModifiedBy { get; set; }
        public DateTime? ItemSaleValidityTo { get; set; }
        public DateTime? ItemSaleValidityFrom { get; set; }
        public bool? IsManualUpdationForItemPrice { get; set; }
        public bool? IsDiscountAllowed { get; set; }
        public bool? ItemHasFixing { get; set; }
        public int? FixingCommissionCategoryId { get; set; }
        public int? ItemSortOrder { get; set; }
        public bool? IsProjectItem { get; set; }
        public string ItemAddedby { get; set; }
        public DateTime? ItemAddedWhen { get; set; }
        public string ItemUpdatedBy { get; set; }
        public DateTime? ItemUpdatedWhen { get; set; }

        public virtual CostCentre CostCentre { get; set; }
        public virtual ItemClassifications ItemClass { get; set; }
        public virtual ItemType ItemType { get; set; }
        public virtual Suppliers Supplier { get; set; }
        public virtual Units Unit { get; set; }
        public virtual ICollection<DeliveryNoteDetail> DeliveryNoteDetail { get; set; }
        public virtual ICollection<DeliveryNoteItemDetail> DeliveryNoteItemDetail { get; set; }
        public virtual ICollection<ItemAttributes> ItemAttributes { get; set; }
        public virtual ICollection<ItemGroupDetails> ItemGroupDetails { get; set; }
        public virtual ICollection<ItemPricing> ItemPricing { get; set; }
        public virtual ICollection<MemitemsIssued> MemitemsIssued { get; set; }
        public virtual ICollection<SalesCashInvoiceDetails> SalesCashInvoiceDetails { get; set; }
        public virtual ICollection<SalesMockupInvoiceDetails> SalesMockupInvoiceDetails { get; set; }
        public virtual ICollection<SalesQuotationDetails> SalesQuotationDetails { get; set; }
        public virtual ICollection<SalesSampleInvoiceDetails> SalesSampleInvoiceDetails { get; set; }
        public virtual ICollection<SrmreturnedItems> SrmreturnedItems { get; set; }
        public virtual ICollection<StoreIssueVoucherDetail> StoreIssueVoucherDetail { get; set; }
  
    }
}
