using System;
using System.Collections.Generic;

namespace Nbn.eCommenrce.ItemService.Models
{
    public partial class SalesPriceValidity
    {
        public SalesPriceValidity()
        {
            SalesQuotation = new HashSet<SalesQuotation>();
        }

        public int PriceValidityId { get; set; }
        public string PriceValidityName { get; set; }
        public int? PriceValidityDays { get; set; }
        public bool? PriceValidityIsActive { get; set; }
        public string PriceValidityAddedby { get; set; }
        public DateTime? PriceValidityAddedWhen { get; set; }
        public string PriceValidityUpdatedBy { get; set; }
        public DateTime? PriceValidityUpdatedWhen { get; set; }

        public virtual ICollection<SalesQuotation> SalesQuotation { get; set; }
    }
}
