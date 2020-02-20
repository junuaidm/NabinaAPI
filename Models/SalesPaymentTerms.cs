using System;
using System.Collections.Generic;

namespace Nbn.eCommenrce.ItemService.Models
{
    public partial class SalesPaymentTerms
    {
        public SalesPaymentTerms()
        {
            SalesQuotation = new HashSet<SalesQuotation>();
        }

        public int PaymentTermsId { get; set; }
        public string PaymentTermsName { get; set; }
        public int? PaymentTermsDays { get; set; }
        public bool? PaymentTermsIsActive { get; set; }
        public string PaymentTermsAddedBy { get; set; }
        public DateTime? PaymentTermsAddedWhen { get; set; }
        public string PaymentTermsUpdatedBy { get; set; }
        public DateTime? PaymentTermsUpdatedWhen { get; set; }

        public virtual ICollection<SalesQuotation> SalesQuotation { get; set; }
    }
}
