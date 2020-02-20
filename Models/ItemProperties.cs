using System;
using System.Collections.Generic;

namespace Nbn.eCommenrce.ItemService.Models
{
    public partial class ItemProperties
    {
        public int ItemPropertyId { get; set; }
        public int? ItemId { get; set; }
        public int? SubCategId { get; set; }
        public bool? ItemPropertyIsActive { get; set; }
        public string ItemPropertyAddedBy { get; set; }
        public DateTime? ItemPropertyAddedWhen { get; set; }
        public string ItemPropertyModifiedBy { get; set; }
        public DateTime? ItemPropertyModifiedWhen { get; set; }

        public virtual ItemSubCategories SubCateg { get; set; }
    }
}
