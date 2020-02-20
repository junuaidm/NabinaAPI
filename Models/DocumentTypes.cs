using System;
using System.Collections.Generic;

namespace Nbn.eCommenrce.ItemService.Models
{
    public partial class DocumentTypes
    {
        public int DocTypeId { get; set; }
        public string DocTypeName { get; set; }
        public string DocTypeDesc { get; set; }
        public bool? DocTypeIsActive { get; set; }
        public string DocTypeAddedBy { get; set; }
        public DateTime? DocTypeAddedWhen { get; set; }
        public string DocTypeUpdatedBy { get; set; }
        public DateTime? DocTypeUpdatedWhen { get; set; }
    }
}
