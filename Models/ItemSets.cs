using System;
using System.Collections.Generic;

namespace Nbn.eCommenrce.ItemService.Models
{
    public partial class ItemSets
    {
        public ItemSets()
        {
            ItemSetDetails = new HashSet<ItemSetDetails>();
            ItemSetsImages = new HashSet<ItemSetsImages>();
            SalesQuotationDetails = new HashSet<SalesQuotationDetails>();
        }

        public int SetId { get; set; }
        public string SetName { get; set; }
        public string SetCode { get; set; }
        public string SetDesc { get; set; }
        public bool? SetIsActive { get; set; }
        public DateTime? SetDateFrom { get; set; }
        public DateTime? SetDateTo { get; set; }
        public string SetDescArabic { get; set; }
        public string SetAddedBy { get; set; }
        public DateTime? SetAddedWhen { get; set; }
        public string SetUpdatedBy { get; set; }
        public DateTime? SetUpdatedWhen { get; set; }

        public virtual ICollection<ItemSetDetails> ItemSetDetails { get; set; }
        public virtual ICollection<ItemSetsImages> ItemSetsImages { get; set; }
        public virtual ICollection<SalesQuotationDetails> SalesQuotationDetails { get; set; }
    }
}
