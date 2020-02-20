using System;
using System.Collections.Generic;

namespace Nbn.eCommenrce.ItemService.Models
{
    public partial class ProjectDocuments
    {
        public int PrjDocId { get; set; }
        public int? ProjectId { get; set; }
        public int? DocTypeId { get; set; }
        public string PrjDocName { get; set; }
        public string PrjDocDesc { get; set; }
        public string PrjDocFileType { get; set; }
        public string PrjDocFileName { get; set; }
        public bool? PrjDocIsActive { get; set; }
        public byte[] PrjDocFileImage { get; set; }
        public string PrjDocAddedBy { get; set; }
        public DateTime? PrjDocAddedWhen { get; set; }
        public string PrjDocUpdatedBy { get; set; }
        public DateTime? PrjDocUpdatedWhen { get; set; }

        public virtual Projects Project { get; set; }
    }
}
