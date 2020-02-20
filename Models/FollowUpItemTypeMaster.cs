using System;
using System.Collections.Generic;

namespace Nbn.eCommenrce.ItemService.Models
{
    public partial class FollowUpItemTypeMaster
    {
        public int FollowUpItemTypeMasterId { get; set; }
        public string FollowUpItemTypeMasterName { get; set; }
        public string FollowUpItemTypeMasterAddedBy { get; set; }
        public DateTime? FollowUpItemTypeMasterAddedWhen { get; set; }
        public string FollowUpItemTypeMasterUpdatedBy { get; set; }
        public DateTime? FollowUpItemTypeMasterUpdatedWhen { get; set; }
    }
}
