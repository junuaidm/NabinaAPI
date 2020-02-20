using System;
using System.Collections.Generic;

namespace Nbn.eCommenrce.ItemService.Models
{
    public partial class SalesQuotationDocuments
    {
        public int SqdocId { get; set; }
        public int? SalesQuoteId { get; set; }
        public string SqdocName { get; set; }
        public string SqdocDesc { get; set; }
        public string SqdocFileType { get; set; }
        public string SqdocFileName { get; set; }
        public bool? SqdocIsActive { get; set; }
        public byte[] SqdocFileImage { get; set; }
        public bool? SqisDesignDoc { get; set; }
        public string SqdocAddedBy { get; set; }
        public DateTime? SqdocAddedWhen { get; set; }
        public string SqdocUpdatedBy { get; set; }
        public DateTime? SqdocUpdatedWhen { get; set; }

        public virtual SalesQuotation SalesQuote { get; set; }
    }
}
