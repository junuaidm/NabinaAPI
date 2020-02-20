using System;
using System.Collections.Generic;

namespace Nbn.eCommenrce.ItemService.Models
{
    public partial class ItemCategories
    {
        public ItemCategories()
        {
            ItemSubCategories = new HashSet<ItemSubCategories>();
            ItemTypeCategories = new HashSet<ItemTypeCategories>();
        }

        public int ItemCategId { get; set; }
        public string ItemCategName { get; set; }
        public string ItemCategCode { get; set; }
        public string ItemCategDesc { get; set; }
        public bool? ItemCategHasUnit { get; set; }
        public int? UnitId { get; set; }
        public bool? ItemCategIsActive { get; set; }
        public bool? ItemCategIsPrintOnDocument { get; set; }
        public string ItemCategAddedBy { get; set; }
        public DateTime? ItemCategAddedWhen { get; set; }
        public string ItemCategUpdatedBy { get; set; }
        public DateTime? ItemCategUpdatedWhen { get; set; }

        public virtual ICollection<ItemSubCategories> ItemSubCategories { get; set; }
        public virtual ICollection<ItemTypeCategories> ItemTypeCategories { get; set; }
    }
}
