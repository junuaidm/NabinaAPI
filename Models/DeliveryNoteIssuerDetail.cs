using System;
using System.Collections.Generic;

namespace Nbn.eCommenrce.ItemService.Models
{
    public partial class DeliveryNoteIssuerDetail
    {
        public int DnissuerDetailId { get; set; }
        public int? DeliveryNoteId { get; set; }
        public int? ClerkId { get; set; }
        public string DnissuerDetailAddedBy { get; set; }
        public DateTime? DnissuerDetailAddedWhen { get; set; }
        public string DnissuerDetailUpdatedBy { get; set; }
        public DateTime? DnissuerDetailUpdatedWhen { get; set; }
    }
}
