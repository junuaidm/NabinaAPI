using System;
using System.Collections.Generic;

namespace Nbn.eCommenrce.ItemService.Models
{
    public partial class ProjectType
    {
        public int ProjectTypeId { get; set; }
        public string ProjectTypeName { get; set; }
        public string ProjectTypeAddedBy { get; set; }
        public DateTime? ProjectTypeAddedWhen { get; set; }
        public string ProjectTypeUpdatedBy { get; set; }
        public DateTime? ProjectTypeUpdatedWhen { get; set; }
    }
}
