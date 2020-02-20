using System;
using System.Collections.Generic;

namespace Nbn.eCommenrce.ItemService.Models
{
    public partial class FollowUpItemTypes
    {
        public int FollowUpItemTypeId { get; set; }
        public int? FollowUpId { get; set; }
        public int? FollowUpItemTypeMasterId { get; set; }
        public string FollowUpItemTypeAddedBy { get; set; }
        public DateTime? FollowUpItemTypeAddedWhen { get; set; }
        public string FollowUpItemTypeUpdatedBy { get; set; }
        public DateTime? FollowUpItemTypeUpdatedWhen { get; set; }
    }
}
