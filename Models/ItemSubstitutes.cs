using System;
using System.Collections.Generic;

namespace Nbn.eCommenrce.ItemService.Models
{
    public partial class ItemSubstitutes
    {
        public int ItemSubId { get; set; }
        public int ItemId { get; set; }
        public int? SubstituteItemId { get; set; }
        public string ItemSubRemarks { get; set; }
        public bool? ItemSubIsActive { get; set; }
        public string ItemSubAddedBy { get; set; }
        public DateTime? ItemSubAddedWhen { get; set; }
        public string ItemSubUpdatedBy { get; set; }
        public DateTime? ItemSubUpdatedWhen { get; set; }
    }
}
