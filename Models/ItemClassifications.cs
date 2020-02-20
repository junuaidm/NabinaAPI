using System;
using System.Collections.Generic;

namespace Nbn.eCommenrce.ItemService.Models
{
    public partial class ItemClassifications
    {
        public ItemClassifications()
        {
            Items = new HashSet<Items>();
        }

        public int ItemClassId { get; set; }
        public string ItemClassName { get; set; }
        public string ItemClassDesc { get; set; }
        public bool? ItemClassIsActive { get; set; }
        public bool? ItemClassNonEditable { get; set; }
        public bool? ItemClassItemCanBeSold { get; set; }
        public bool? ItemClassSalesFactor { get; set; }
        public bool? ItemClassLabourFactor { get; set; }
        public int? SalesRevenueAccountId { get; set; }
        public int? SalesSampleInvoiceAccountId { get; set; }
        public int? GrnrevenueAccountId { get; set; }
        public int? StockAccountId { get; set; }
        public int? CostOfSalesAccountId { get; set; }
        public int? FactoryStockAccountId { get; set; }
        public int? GoodsInTransitAccountId { get; set; }
        public bool? ItemClassIsManualPrice { get; set; }
        public string ItemClassAddedBy { get; set; }
        public DateTime? ItemClassAddedWhen { get; set; }
        public string ItemClassUpdatedBy { get; set; }
        public DateTime? ItemClassUpdatedWhen { get; set; }

        public virtual ICollection<Items> Items { get; set; }
    }
}
