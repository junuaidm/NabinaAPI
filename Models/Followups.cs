using System;
using System.Collections.Generic;

namespace Nbn.eCommenrce.ItemService.Models
{
    public partial class Followups
    {
        public int FollowupId { get; set; }
        public string FollowupType { get; set; }
        public string FollowupFor { get; set; }
        public int? FollowupRefId { get; set; }
        public int? StakeHolderId { get; set; }
        public DateTime? FollowupDate { get; set; }
        public TimeSpan? FollowupTime { get; set; }
        public string FollowupContact { get; set; }
        public string FollowupAssignedTo { get; set; }
        public int? FollowupMode { get; set; }
        public string FollowupShortDesc { get; set; }
        public string FollowupDetails { get; set; }
        public byte[] FollowupDocFile { get; set; }
        public string FollowupDocFileName { get; set; }
        public string FollowupDocFileType { get; set; }
        public string FollowupAssignedBy { get; set; }
        public int? FollowupAssignedByUserId { get; set; }
        public int? FollowupAssignedToSalesPersonId { get; set; }
        public string FollowupAddedBy { get; set; }
        public DateTime? FollowupAddedWhen { get; set; }
        public string FollowupUpdatedBy { get; set; }
        public DateTime? FollowupUpdatedWhen { get; set; }
    }
}
