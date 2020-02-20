using System;
using System.Collections.Generic;

namespace Nbn.eCommenrce.ItemService.Models
{
    public partial class TimeOfDeliveries
    {
        public int Todid { get; set; }
        public string Todname { get; set; }
        public string TodaddedBy { get; set; }
        public DateTime? TodaddedWhen { get; set; }
        public string TodupdatedBy { get; set; }
        public DateTime? TodupdatedWhen { get; set; }
    }
}
