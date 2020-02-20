using System;
using System.Collections.Generic;

namespace Nbn.eCommenrce.ItemService.Models
{
    public partial class ItemGroups
    {
        public ItemGroups()
        {
            ItemGroupDetails = new HashSet<ItemGroupDetails>();
        }

        public int GroupId { get; set; }
        public string GroupName { get; set; }
        public string GroupDesc { get; set; }
        public string GroupCode { get; set; }
        public bool? GroupIsActive { get; set; }
        public decimal? GroupPrice { get; set; }
        public string GroupAddedBy { get; set; }
        public DateTime? GroupAddedWhen { get; set; }
        public string GroupUpdatedBy { get; set; }
        public DateTime? GroupUpdatedWhen { get; set; }

        public virtual ICollection<ItemGroupDetails> ItemGroupDetails { get; set; }
    }
}
