using System;
using System.Collections.Generic;

namespace Nbn.eCommenrce.ItemService.Models
{
    public partial class SampleVoucherRequestDetail
    {
        public int SvrdetailId { get; set; }
        public int? Svrid { get; set; }
        public int? ItemId { get; set; }
        public int? UnitId { get; set; }
        public decimal? SvrdetailQuantity { get; set; }
        public decimal? ItemActualStock { get; set; }
        public decimal? ItemGroundStock { get; set; }
        public string SvrdetailAddedBy { get; set; }
        public DateTime? SvrdetailAddedWhen { get; set; }
        public string SvrdetailUpdatedBy { get; set; }
        public DateTime? SvrdetailUpdatedWhen { get; set; }
    }
}
