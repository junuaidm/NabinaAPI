using System;
using System.Collections.Generic;

namespace Nbn.eCommenrce.ItemService.Models
{
    public partial class UnitOfConversion
    {
        public int ConversionId { get; set; }
        public int? UnitIdto { get; set; }
        public int? UnitIdfrom { get; set; }
        public int? ItemId { get; set; }
        public decimal? ConversionRate { get; set; }
        public decimal? ActualRateForSteel { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsInvoiceAllowed { get; set; }
        public string ConversionAddedBy { get; set; }
        public DateTime? ConversionAddedWhen { get; set; }
        public string ConversionUpdatedBy { get; set; }
        public DateTime? ConversionUpdatedWhen { get; set; }

        public virtual Units UnitIdfromNavigation { get; set; }
        public virtual Units UnitIdtoNavigation { get; set; }
    }
}
