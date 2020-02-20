using System;
using System.Collections.Generic;

namespace Nbn.eCommenrce.ItemService.Models
{
    public partial class SqdeliveryAddress
    {
        public int SqdeliveryAddressId { get; set; }
        public int? SalesQuoteId { get; set; }
        public int? LocationId { get; set; }
        public string SqdeliveryAddress1 { get; set; }
        public decimal? SqdeliveryCharge { get; set; }
        public int? SqdeliveryNoOfTrips { get; set; }
        public string SqdeliveryDescr { get; set; }
        public string SqdeliveryAddressAddedBy { get; set; }
        public DateTime? SqdeliveryAddressAddedWhen { get; set; }
        public string SqdeliveryAddressUpdatedBy { get; set; }
        public DateTime? SqdeliveryAddressUpdatedWhen { get; set; }

        public virtual LocationCharges Location { get; set; }
        public virtual SalesQuotation SalesQuote { get; set; }
    }
}
