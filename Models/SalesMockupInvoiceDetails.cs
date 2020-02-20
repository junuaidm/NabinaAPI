using System;
using System.Collections.Generic;

namespace Nbn.eCommenrce.ItemService.Models
{
    public partial class SalesMockupInvoiceDetails
    {
        public int SlmockupInvoiceDetailId { get; set; }
        public int? SalesMockupInvoiceId { get; set; }
        public int? SalesQuoteId { get; set; }
        public int? SqdetailId { get; set; }
        public int? SetId { get; set; }
        public int? IsdetailId { get; set; }
        public int? ItemId { get; set; }
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
        public decimal? SlmockupInvoiceDetailItemSetQty { get; set; }
        public decimal? SlmockupInvoiceDetailItemQty { get; set; }
        public decimal? SlmockupInvoiceDetailItemActualQty { get; set; }
        public decimal? SlmockupInvoiceDetailItemBaseUnitQty { get; set; }
        public decimal? SlmockUpInvoiceDetailItemAvailableQty { get; set; }
        public decimal? SlmockupInvoiceDetailItemCost { get; set; }
        public decimal? SlmockupInvoiceDetailItemLabourFactor { get; set; }
        public decimal? SlmockupInvoiceDetailItemPrice { get; set; }
        public decimal? SlmockupInvoiceDetailUnitPrice { get; set; }
        public decimal? SlmockupInvoiceDetailItemDiscountPercentage { get; set; }
        public decimal? SlmockupInvoiceDetailItemDiscountAmount { get; set; }
        public decimal? SlmockupInvoiceDetailItemNetAmount { get; set; }
        public int? SlmockupInvoiceDetailSerialNo { get; set; }
        public string SlmockupInvoiceDetailAddedBy { get; set; }
        public DateTime? SlmockupInvoiceDetailAddedWhen { get; set; }
        public string SlmockupInvoiceDetailUpdatedBy { get; set; }
        public DateTime? SlmockupInvoiceDetailUpdatedWhen { get; set; }

        public virtual Items Item { get; set; }
    }
}
