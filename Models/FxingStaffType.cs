using System;
using System.Collections.Generic;

namespace Nbn.eCommenrce.ItemService.Models
{
    public partial class FxingStaffType
    {
        public int FixingStaffTypeId { get; set; }
        public string FixingStaffTypeName { get; set; }
        public bool? FixingStaffTypeIsActive { get; set; }
        public string FixingStaffTypeAddedBy { get; set; }
        public DateTime? FixingStaffTypeAddedWhen { get; set; }
        public string FixingStaffTypeUpdatedBy { get; set; }
        public DateTime? FixingStaffTypeUpdatedWhen { get; set; }
    }
}
