using System;
using System.Collections.Generic;

namespace Nbn.eCommenrce.ItemService.Models
{
    public partial class InvoiceItemCategoryDetail
    {
        public int InvoiceItemCategDetailId { get; set; }
        public int? InvoiceItemCategoryId { get; set; }
        public int? ItemTypeId { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedWhen { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedWhen { get; set; }
    }
}
