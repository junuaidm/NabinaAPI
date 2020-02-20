using System;
using System.Collections.Generic;

namespace Nbn.eCommenrce.ItemService.Models
{
    public partial class DeliveryNoteReceiverTypeMaster
    {
        public int DeliveryNoteReceiverTypeId { get; set; }
        public string DeliveryNoteReceiverTypeName { get; set; }
        public bool? DeliveryNoteReceiverTypeIsActive { get; set; }
        public string DeliveryNoteReceiverTypeAddedBy { get; set; }
        public DateTime? DeliveryNoteReceiverTypeAddedWhen { get; set; }
        public string DeliveryNoteReceiverTypeUpdatedBy { get; set; }
        public DateTime? DeliveryNoteReceiverTypeUpdatedWhen { get; set; }
    }
}
