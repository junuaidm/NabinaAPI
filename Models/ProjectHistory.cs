using System;
using System.Collections.Generic;

namespace Nbn.eCommenrce.ItemService.Models
{
    public partial class ProjectHistory
    {
        public int ProjectHistoryId { get; set; }
        public int? ProjectId { get; set; }
        public string ProjectHistoryTableName { get; set; }
        public int? ProjectHistoryTableId { get; set; }
        public string ProjectHistoryChanges { get; set; }
        public DateTime? ProjectHistoryDate { get; set; }
        public string ProjectHistoryAddedBy { get; set; }
        public DateTime? ProjectHistoryAddedWhen { get; set; }
        public string ProjectHistoryUpdatedBy { get; set; }
        public DateTime? ProjectHistoryUpdatedWhen { get; set; }
    }
}
