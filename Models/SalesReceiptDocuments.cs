using System;
using System.Collections.Generic;

namespace Nbn.eCommenrce.ItemService.Models
{
    public partial class SalesReceiptDocuments
    {
        public int SrdocId { get; set; }
        public int? SalesReceiptId { get; set; }
        public string SrdocName { get; set; }
        public string SrdocDesc { get; set; }
        public string SrdocFileType { get; set; }
        public string SrdocFileName { get; set; }
        public bool? SrdocIsActive { get; set; }
        public string SrdocAddedBy { get; set; }
        public DateTime? SrdocAddedWhen { get; set; }
        public string SrdocUpdatedBy { get; set; }
        public DateTime? SrdocUpdatedWhen { get; set; }
    }
}
