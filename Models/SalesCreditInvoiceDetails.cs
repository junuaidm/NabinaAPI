using System;
using System.Collections.Generic;

namespace Nbn.eCommenrce.ItemService.Models
{
    public partial class SalesCreditInvoiceDetails
    {
        public int SlcreditInvoiceDetailId { get; set; }
        public int? SalesCreditInvoiceId { get; set; }
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
        public decimal? SlcreditInvoiceDetailItemSetQty { get; set; }
        public decimal? SlcreditInvoiceDetailItemQty { get; set; }
        public decimal? SlcreditInvoiceDetailItemActualQty { get; set; }
        public decimal? SlcreditInvoiceDetailItemBaseUnitQty { get; set; }
        public decimal? SlcreditInvoiceDetailItemAvailableQty { get; set; }
        public decimal? SlcreditInvoiceDetailItemCost { get; set; }
        public decimal? SlcreditInvoiceDetailItemLabourFactor { get; set; }
        public decimal? SlcreditInvoiceDetailItemPrice { get; set; }
        public decimal? SlcreditInvoiceDetailUnitPrice { get; set; }
        public decimal? SlcreditInvoiceDetailItemDiscountPercentage { get; set; }
        public decimal? SlcreditInvoiceDetailItemDiscountAmount { get; set; }
        public decimal? SlcreditInvoiceDetailItemNetAmount { get; set; }
        public int? SlcreditInvoiceDetailSerialNo { get; set; }
        public string SlcreditInvoiceDetailAddedBy { get; set; }
        public DateTime? SlcreditInvoiceDetailAddedWhen { get; set; }
        public string SlcreditInvoiceDetailUpdatedBy { get; set; }
        public DateTime? SlcreditInvoiceDetailUpdatedWhen { get; set; }
    }
}
