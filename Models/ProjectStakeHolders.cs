using System;
using System.Collections.Generic;

namespace Nbn.eCommenrce.ItemService.Models
{
    public partial class ProjectStakeHolders
    {
        public int ProjectStakeHolderId { get; set; }
        public int? ProjectId { get; set; }
        public int? StakeHolderTypeId { get; set; }
        public string ProjectStakeHolderName { get; set; }
        public string ProjectStakeHolderPhone { get; set; }
        public string ProjectStakeHolderMobile { get; set; }
        public string ProjectStakeHolderFax { get; set; }
        public string ProjectStakeHolderEmail { get; set; }
        public string ProjectStakeHolderRemarks { get; set; }
        public string ProjectStakeHolderAddedBy { get; set; }
        public DateTime? ProjectStakeHolderAddedWhen { get; set; }
        public string ProjectStakeHolderUpdatedBy { get; set; }
        public DateTime? ProjectStakeHolderUpdatedWhen { get; set; }

        public virtual Projects Project { get; set; }
    }
}
