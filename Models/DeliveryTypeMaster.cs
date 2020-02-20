using System;
using System.Collections.Generic;

namespace Nbn.eCommenrce.ItemService.Models
{
    public partial class DeliveryTypeMaster
    {
        public int DeliveryTypeId { get; set; }
        public string DeliveryTypeName { get; set; }
        public bool? DeliveryTypeIsActive { get; set; }
        public string DeliveryTypeAddedBy { get; set; }
        public DateTime? DeliveryTypeAddedWhen { get; set; }
        public string DeliveryTypeUpdatedBy { get; set; }
        public DateTime? DeliveryTypeUpdatedWhen { get; set; }
    }
}
