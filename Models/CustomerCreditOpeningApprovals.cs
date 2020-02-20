using System;
using System.Collections.Generic;

namespace Nbn.eCommenrce.ItemService.Models
{
    public partial class CustomerCreditOpeningApprovals
    {
        public int CustomerCreditOpeningApprovalId { get; set; }
        public int? DocumentId { get; set; }
        public int? MenuApprovalId { get; set; }
        public int? ApproverUserId { get; set; }
        public int? RoleId { get; set; }
        public int? UserId { get; set; }
        public bool? IsApproved { get; set; }
        public DateTime? ApprovalDate { get; set; }
        public int? Sequence { get; set; }
    }
}
