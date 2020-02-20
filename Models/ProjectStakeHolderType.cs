using System;
using System.Collections.Generic;

namespace Nbn.eCommenrce.ItemService.Models
{
    public partial class ProjectStakeHolderType
    {
        public int StakeHolderTypeId { get; set; }
        public string StakeHolderTypeName { get; set; }
        public string StakeHolderTypeAddedBy { get; set; }
        public DateTime? StakeHolderTypeAddedWhen { get; set; }
        public string StakeHolderTypeUpdatedBy { get; set; }
        public DateTime? StakeHolderTypeUpdatedWhen { get; set; }
    }
}
