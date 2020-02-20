using System;
using System.Collections.Generic;

namespace Nbn.eCommenrce.ItemService.Models
{
    public partial class SalesCashInvoiceDetails
    {
        public int SlcashInvoiceDetailId { get; set; }
        public int? SalesCashInvoiceId { get; set; }
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
        public decimal? SlcashInvoiceDetailItemSetQty { get; set; }
        public decimal? SlcashInvoiceDetailItemQty { get; set; }
        public decimal? SlcashInvoiceDetailItemActualQty { get; set; }
        public decimal? SlcashInvoiceDetailItemBaseUnitQty { get; set; }
        public decimal? SlcashInvoiceDetailItemAvailableQty { get; set; }
        public decimal? SlcashInvoiceDetailItemCost { get; set; }
        public decimal? SlcashInvoiceDetailItemLabourFactor { get; set; }
        public decimal? SlcashInvoiceDetailItemPrice { get; set; }
        public decimal? SlcashInvoiceDetailUnitPrice { get; set; }
        public decimal? SlcashInvoiceDetailItemDiscountPercentage { get; set; }
        public decimal? SlcashInvoiceDetailItemDiscountAmount { get; set; }
        public decimal? SlcashInvoiceDetailItemNetAmount { get; set; }
        public int? SlcashInvoiceDetailSerialNo { get; set; }
        public string SlcashInvoiceDetailAddedBy { get; set; }
        public DateTime? SlcashInvoiceDetailAddedWhen { get; set; }
        public string SlcashInvoiceDetailUpdatedBy { get; set; }
        public DateTime? SlcashInvoiceDetailUpdatedWhen { get; set; }

        public virtual Items Item { get; set; }
    }
}
