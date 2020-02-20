using System;
using System.Collections.Generic;

namespace Nbn.eCommenrce.ItemService.Models
{
    public partial class SalesContractDocuments
    {
        public int ScdocId { get; set; }
        public int? Scid { get; set; }
        public int? ScdocTypeId { get; set; }
        public string ScdocName { get; set; }
        public string ScdocRemarks { get; set; }
        public string ScdocFileType { get; set; }
        public string ScdocFileName { get; set; }
        public bool? ScdocIsActive { get; set; }
        public string ScdocAddedBy { get; set; }
        public DateTime? ScdocAddedWhen { get; set; }
        public string ScdocUpdatedBy { get; set; }
        public DateTime? ScdocUpdatedWhen { get; set; }
    }
}
