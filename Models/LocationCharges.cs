using System;
using System.Collections.Generic;

namespace Nbn.eCommenrce.ItemService.Models
{
    public partial class LocationCharges
    {
        public LocationCharges()
        {
            SqdeliveryAddress = new HashSet<SqdeliveryAddress>();
        }

        public int LocationId { get; set; }
        public string LocationName { get; set; }
        public string LocationDescription { get; set; }
        public decimal? LocationCharge { get; set; }
        public bool? LocationIsActive { get; set; }
        public string LocationAddedBy { get; set; }
        public DateTime? LocationAddedWhen { get; set; }
        public string LocationUpdatedBy { get; set; }
        public DateTime? LocationUpdatedWhen { get; set; }

        public virtual ICollection<SqdeliveryAddress> SqdeliveryAddress { get; set; }
    }
}
