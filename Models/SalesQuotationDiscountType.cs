using System;
using System.Collections.Generic;

namespace Nbn.eCommenrce.ItemService.Models
{
    public partial class SalesQuotationDiscountType
    {
        public int SalesQuoteDiscountTypeId { get; set; }
        public string SalesQuoteDiscountTypeName { get; set; }
        public bool? SalesQuoteDiscountTypeIsActive { get; set; }
        public string SalesQuoteDiscountTypeAddedBy { get; set; }
        public DateTime? SalesQuoteDiscountTypeAddedWhen { get; set; }
        public string SalesQuoteDiscountTypeUpdatedBy { get; set; }
        public DateTime? SalesQuoteDiscountTypeUpdateWhen { get; set; }
    }
}
