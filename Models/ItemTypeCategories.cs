using System;
using System.Collections.Generic;

namespace Nbn.eCommenrce.ItemService.Models
{
    public partial class ItemTypeCategories
    {
        public int ItemTypeCategId { get; set; }
        public int? ItemTypeId { get; set; }
        public int? ItemCategId { get; set; }
        public bool? ItemTypeCategIsMandatory { get; set; }
        public bool? ItemTypeCategIsActive { get; set; }
        public string Remarks { get; set; }
        public string ItemTypeCategoriesAddedBy { get; set; }
        public DateTime? ItemTypeCategoriesAddedWhen { get; set; }
        public string ItemTypeCategoriesModifiedBy { get; set; }
        public DateTime? ItemTypeCategoriesModifiedWhen { get; set; }

        public virtual ItemCategories ItemCateg { get; set; }
        public virtual ItemType ItemType { get; set; }
    }
}
