using System;
using System.Collections.Generic;

namespace Nbn.eCommenrce.ItemService.Models
{
    public partial class SalesQuotationType
    {
        public SalesQuotationType()
        {
            SalesQuotation = new HashSet<SalesQuotation>();
        }

        public int SalesQuoteTypeId { get; set; }
        public string SalesQuoteTypeName { get; set; }
        public int? SalesQuoteTypeIsActive { get; set; }
        public string SalesQuoteTypeAddedBy { get; set; }
        public DateTime? SalesQuoteTypeAddedWhen { get; set; }
        public string SalesQuoteTypeUpdatedBy { get; set; }
        public DateTime? SalesQuoteTypeUpdatedWhen { get; set; }

        public virtual ICollection<SalesQuotation> SalesQuotation { get; set; }
    }
}
