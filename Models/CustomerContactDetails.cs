using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Nbn.eCommenrce.ItemService.Models
{
    public partial class CustomerContactDetails
    {
        public CustomerContactDetails()
        {
            SalesQuotation = new HashSet<SalesQuotation>();
        }
        [Key]
        public int ContactDetId { get; set; }
        public int? CustomerId { get; set; }
        public string ContactDetTitle { get; set; }
        public string ContactName { get; set; }
        public string ContactDesignation { get; set; }
        public string ContactTelNo { get; set; }
        public string ContactMobile { get; set; }
        public string ContactEmail { get; set; }
        public string ContactFax { get; set; }
        public bool? ContactIsActive { get; set; }
        public bool? ContactIsPrimary { get; set; }
        public string ContactAddedBy { get; set; }
        public DateTime? ContactAddedWhen { get; set; }
        public string ContactUpdatedBy { get; set; }
        public DateTime? ContactUpdatedWhen { get; set; }

        public virtual CustomerMaster Customer { get; set; }
        public virtual ICollection<SalesQuotation> SalesQuotation { get; set; }
    }
}
