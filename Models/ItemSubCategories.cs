using System;
using System.Collections.Generic;

namespace Nbn.eCommenrce.ItemService.Models
{
    public partial class ItemSubCategories
    {
        public ItemSubCategories()
        {
            ItemProperties = new HashSet<ItemProperties>();
            ItemSubCategoryItemTypes = new HashSet<ItemSubCategoryItemTypes>();
        }

        public int SubCategId { get; set; }
        public string SubCategName { get; set; }
        public int? ItemCategId { get; set; }
        public bool? SubCategIsForItemType { get; set; }
        public bool? SubCategIsActive { get; set; }
        public string SubCategRemarks { get; set; }
        public DateTime? SubCategAddedWhen { get; set; }
        public string SubCategAddedBy { get; set; }
        public string SubCategUpdatedBy { get; set; }
        public DateTime? SubCategUpdatedWhen { get; set; }

        public virtual ItemCategories ItemCateg { get; set; }
        public virtual ICollection<ItemProperties> ItemProperties { get; set; }
        public virtual ICollection<ItemSubCategoryItemTypes> ItemSubCategoryItemTypes { get; set; }
    }
}
