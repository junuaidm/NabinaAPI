using System;
using System.Collections.Generic;

namespace Nbn.eCommenrce.ItemService.Models
{
    public partial class SalesReturnConfirmationDetails
    {
        public int SrcdetailId { get; set; }
        public int? Srcid { get; set; }
        public int? SivdetailId { get; set; }
        public decimal? SrcdetailReturnedQty { get; set; }
        public decimal? SrcdetailReturnedActualQty { get; set; }
        public string SrcdetailAddedBy { get; set; }
        public DateTime? SrcdetailAddedWhen { get; set; }
        public DateTime? SrcdetailUpdatedWhen { get; set; }
        public string SrcdetailUpdatedBy { get; set; }
    }
}
