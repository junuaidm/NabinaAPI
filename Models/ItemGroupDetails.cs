using System;
using System.Collections.Generic;

namespace Nbn.eCommenrce.ItemService.Models
{
    public partial class ItemGroupDetails
    {
        public int IgdetailId { get; set; }
        public int GroupId { get; set; }
        public int ItemId { get; set; }
        public decimal? IgdetailQty { get; set; }
        public bool? IgdetailIsActive { get; set; }
        public string IgdetailAddedBy { get; set; }
        public DateTime? IgdetailAddedWhen { get; set; }
        public string IgdetailUpdatedBy { get; set; }
        public DateTime? IgdetailUpdatedWhen { get; set; }
        public string IgdetailDesc { get; set; }

        public virtual ItemGroups Group { get; set; }
        public virtual Items Item { get; set; }
    }
}
