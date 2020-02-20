using System;
using System.Collections.Generic;

namespace Nbn.eCommenrce.ItemService.Models
{
    public partial class TermsOfDelivery
    {
        public int DelTermId { get; set; }
        public string DelTermName { get; set; }
        public string DelTermAddedBy { get; set; }
        public DateTime? DelTermAddedWhen { get; set; }
        public string DelTermUpdatedBy { get; set; }
        public DateTime? DelTermUpdatedWhen { get; set; }
    }
}
