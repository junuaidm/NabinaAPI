using System;
using System.Collections.Generic;

namespace Nbn.eCommenrce.ItemService.Models
{
    public partial class SalesDeliveryTime
    {
        public SalesDeliveryTime()
        {
            SalesQuotation = new HashSet<SalesQuotation>();
        }

        public int DeliveryTimeId { get; set; }
        public string DeliveryTimeName { get; set; }
        public int? DeliveryTimeDaysFrom { get; set; }
        public int? DeliveryTimeDaysTo { get; set; }
        public bool? DeliveryTimeIsActive { get; set; }
        public string DeliveryTimeAddedBy { get; set; }
        public DateTime? DeliveryTimeAddedWhen { get; set; }
        public string DeliveryTimeUpdatedBy { get; set; }
        public DateTime? DeliveryTimeUpdatedWhen { get; set; }

        public virtual ICollection<SalesQuotation> SalesQuotation { get; set; }
    }
}
