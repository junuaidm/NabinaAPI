using System;
using System.Collections.Generic;

namespace Nbn.eCommenrce.ItemService.Models
{
    public partial class TermsOfPayments
    {
        public int Topid { get; set; }
        public string Topname { get; set; }
        public string TopaddedBy { get; set; }
        public DateTime? TopaddedWhen { get; set; }
        public string TopupdatedBy { get; set; }
        public DateTime? TopupdatedWhen { get; set; }
    }
}
