using System;
using System.Collections.Generic;

namespace Nbn.eCommenrce.ItemService.Models
{
    public partial class ItemType
    {
        public ItemType()
        {
            ItemSubCategoryItemTypes = new HashSet<ItemSubCategoryItemTypes>();
            ItemTypeCategories = new HashSet<ItemTypeCategories>();
            Items = new HashSet<Items>();
            SalesGroupDiscount = new HashSet<SalesGroupDiscount>();
        }

        public int ItemTypeId { get; set; }
        public string ItemTypeName { get; set; }
        public string ItemTypeDescription { get; set; }
        public int? ItemParentType { get; set; }
        public int? CostCentreId { get; set; }
        public bool? ItemTypeIsActive { get; set; }
        public int? ItemTypeSortOrder { get; set; }
        public string ItemTypeAddedBy { get; set; }
        public DateTime? ItemTypeAddedWhen { get; set; }
        public DateTime? ItemTypeUpdatedWhen { get; set; }
        public string ItemTypeUpdatedBy { get; set; }

        public virtual ICollection<ItemSubCategoryItemTypes> ItemSubCategoryItemTypes { get; set; }
        public virtual ICollection<ItemTypeCategories> ItemTypeCategories { get; set; }
        public virtual ICollection<Items> Items { get; set; }
        public virtual ICollection<SalesGroupDiscount> SalesGroupDiscount { get; set; }
       
    }
}
