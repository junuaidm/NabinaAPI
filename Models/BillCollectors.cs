using System;
using System.Collections.Generic;

namespace Nbn.eCommenrce.ItemService.Models
{
    public partial class BillCollectors
    {
        public int BillCollectorId { get; set; }
        public string BillCollectorName { get; set; }
        public string BillCollectorShortName { get; set; }
        public int? SalesPersonId { get; set; }
        public bool? BillCollectorIsActive { get; set; }
        public string BillCollectorAddedBy { get; set; }
        public DateTime? BillCollectorAddedWhen { get; set; }
        public string BillCollectorUpdatedBy { get; set; }
        public DateTime? BillCollectorUpdatedWhen { get; set; }
    }
}
