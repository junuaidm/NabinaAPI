using System;
using System.Collections.Generic;

namespace Nbn.eCommenrce.ItemService.Models
{
    public partial class ItemSetDetails
    {
        public ItemSetDetails()
        {
            SalesQuotationDetails = new HashSet<SalesQuotationDetails>();
        }

        public int IsdetailId { get; set; }
        public int SetId { get; set; }
        public int? ItemId { get; set; }
        public decimal? IsdetailQty { get; set; }
        public string IsdetailDesc { get; set; }
        public bool? Isactive { get; set; }
        public int? UnitId { get; set; }
        public int? PricingId { get; set; }
        public string IsdetailAddedBy { get; set; }
        public DateTime? IsdetailAddedWhen { get; set; }
        public string IsdetailUpdatedBy { get; set; }
        public DateTime? IsdetailUpdatedWhen { get; set; }

        public virtual ItemSets Set { get; set; }
        public virtual ICollection<SalesQuotationDetails> SalesQuotationDetails { get; set; }
    }
}
