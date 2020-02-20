using System;
using System.Collections.Generic;

namespace Nbn.eCommenrce.ItemService.Models
{
    public partial class ItemPricing
    {
        public ItemPricing()
        {
            SalesQuotationDetails = new HashSet<SalesQuotationDetails>();
        }

        public int PricingId { get; set; }
        public int ItemId { get; set; }
        public string PricingName { get; set; }
        public decimal? PricingQty { get; set; }
        public byte? PricingType { get; set; }
        public int? PricingFop { get; set; }
        public decimal? PricingPrice { get; set; }
        public bool? PricingIsActive { get; set; }
        public DateTime? PricingFrom { get; set; }
        public DateTime? PricingTo { get; set; }
        public int? UnitId { get; set; }
        public int? CustomerId { get; set; }
        public int? ProjectId { get; set; }
        public int? PaymentTermsId { get; set; }
        public string PricingAddedBy { get; set; }
        public DateTime? PricingAddedWhen { get; set; }
        public string PricingUpdatedBy { get; set; }
        public DateTime? PricingUpdatedWhen { get; set; }
        public string PricingDesc { get; set; }

        public virtual Items Item { get; set; }
        public virtual ICollection<SalesQuotationDetails> SalesQuotationDetails { get; set; }
    }
}
