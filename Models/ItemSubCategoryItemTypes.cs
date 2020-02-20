using System;
using System.Collections.Generic;

namespace Nbn.eCommenrce.ItemService.Models
{
    public partial class ItemSubCategoryItemTypes
    {
        public int ItemSubCategTypeId { get; set; }
        public int? SubCategId { get; set; }
        public int? ItemTypeId { get; set; }
        public bool? ItemSubCategTypeIsActive { get; set; }
        public string ItemSubCategTypeAddedBy { get; set; }
        public DateTime? ItemSubCategTypeAddedWhen { get; set; }
        public string ItemSubCategTypeUpdatedBy { get; set; }
        public DateTime? ItemSubCategTypeUpdatedWhen { get; set; }

        public virtual ItemType ItemType { get; set; }
        public virtual ItemSubCategories SubCateg { get; set; }
    }
}
