using System;
using System.Collections.Generic;

namespace Nbn.eCommenrce.ItemService.Models
{
    public partial class InvoiceItemCategory
    {
        public int InvoiceItemCategoryId { get; set; }
        public string InvoiceItemCategoryName { get; set; }
        public bool? InvoiceItemCategoryStatus { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedWhen { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedWhen { get; set; }
    }
}
