using System;
using System.Collections.Generic;

namespace Nbn.eCommenrce.ItemService.Models
{
    public partial class SampleVoucherRequestMaster
    {
        public int Svrid { get; set; }
        public string Svrcode { get; set; }
        public DateTime? Svrdate { get; set; }
        public string Svrdescription { get; set; }
        public short? Svrstatus { get; set; }
        public string CustomerName { get; set; }
        public decimal? Svramount { get; set; }
        public string RequestedBy { get; set; }
        public string OrderRequestCode { get; set; }
        public string SvraddedBy { get; set; }
        public DateTime? SvraddedWhen { get; set; }
        public string SvrupdatedBy { get; set; }
        public DateTime? SvrupdatedWhen { get; set; }
    }
}
