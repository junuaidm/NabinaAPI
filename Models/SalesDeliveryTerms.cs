using System;
using System.Collections.Generic;

namespace Nbn.eCommenrce.ItemService.Models
{
    public partial class SalesDeliveryTerms
    {
        public SalesDeliveryTerms()
        {
            SalesQuotation = new HashSet<SalesQuotation>();
        }

        public int DeliveryTermsId { get; set; }
        public string DeliveryTermsName { get; set; }
        public bool? DeliveryTermsIsActive { get; set; }
        public string DeliveryTermsAddedBy { get; set; }
        public DateTime? DeliveryTermsAddedWhen { get; set; }
        public string DeliveryTermsUpdatedBy { get; set; }
        public string DeliveryTermsUpdatedWhen { get; set; }

        public virtual ICollection<SalesQuotation> SalesQuotation { get; set; }
    }
}
