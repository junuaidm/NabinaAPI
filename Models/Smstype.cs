using System;
using System.Collections.Generic;

namespace Nbn.eCommenrce.ItemService.Models
{
    public partial class Smstype
    {
        public int SmstypeId { get; set; }
        public string SmstypeName { get; set; }
        public string SmstypeAddedBy { get; set; }
        public DateTime? SmstypeAddedWhen { get; set; }
        public string SmstypeUpdatedBy { get; set; }
        public DateTime? SmstypeUpdatedWhen { get; set; }
    }
}
