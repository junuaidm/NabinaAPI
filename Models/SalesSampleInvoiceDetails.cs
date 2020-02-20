using System;
using System.Collections.Generic;

namespace Nbn.eCommenrce.ItemService.Models
{
    public partial class SalesSampleInvoiceDetails
    {
        public int SlsampleInvoiceDetailId { get; set; }
        public int? SalesSampleInvoiceId { get; set; }
        public int? SalesQuoteId { get; set; }
        public int? SqdetailId { get; set; }
        public int? SetId { get; set; }
        public int? IsdetailId { get; set; }
        public int? ItemId { get; set; }
        public int? ItemClassId { get; set; }
        public string ItemDescription { get; set; }
        public string ItemDescriptionArabic { get; set; }
        public int? PricingId { get; set; }
        public int? UnitId { get; set; }
        public int? BaseUnitId { get; set; }
        public decimal? BaseUnitCost { get; set; }
        public decimal? ItemActualStock { get; set; }
        public decimal? ItemGroundStock { get; set; }
        public decimal? ItemActualStockAtCancellation { get; set; }
        public decimal? ItemCostAtCancellation { get; set; }
        public decimal? SlsampleInvoiceDetailItemSetQty { get; set; }
        public decimal? SlsampleInvoiceDetailItemQty { get; set; }
        public decimal? SlsampleInvoiceDetailItemActualQty { get; set; }
        public decimal? SlsampleInvoiceDetailItemBaseUnitQty { get; set; }
        public decimal? SlsampleInvoiceDetailItemAvailableQty { get; set; }
        public decimal? SlsampleInvoiceDetailItemCost { get; set; }
        public decimal? SlsampleInvoiceDetailItemLabourFactor { get; set; }
        public decimal? SlsampleInvoiceDetailItemPrice { get; set; }
        public decimal? SlsampleInvoiceDetailUnitPrice { get; set; }
        public decimal? SlsampleInvoiceDetailItemDiscountPercentage { get; set; }
        public decimal? SlsampleInvoiceDetailItemDiscountAmount { get; set; }
        public decimal? SlsampleInvoiceDetailItemNetAmount { get; set; }
        public int? SlsampleInvoiceDetailSerialNo { get; set; }
        public string SlsampleInvoiceDetailAddedBy { get; set; }
        public DateTime? SlsampleInvoiceDetailAddedWhen { get; set; }
        public string SlsampleInvoiceDetailUpdatedBy { get; set; }
        public DateTime? SlsampleInvoiceDetailUpdatedWhen { get; set; }

        public virtual Items Item { get; set; }
    }
}
