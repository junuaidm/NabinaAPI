using System;
using System.Collections.Generic;

namespace Nbn.eCommenrce.ItemService.Models
{
    public partial class CustomerSalesPersons
    {
        public int CustSpid { get; set; }
        public int? CustomerId { get; set; }
        public int? SalesPersonId { get; set; }
        public bool? CustSpisDefault { get; set; }
        public DateTime? CustSpactiveFrom { get; set; }
        public DateTime? CustSpactiveTo { get; set; }
        public bool? CustSpisActive { get; set; }
        public string CustSpaddedBy { get; set; }
        public DateTime? CustSpaddedWhen { get; set; }
        public string CustSpupdatedBy { get; set; }
        public DateTime? CustSpupdatedWhen { get; set; }

        public virtual CustomerMaster Customer { get; set; }
        public virtual SalesPersons SalesPerson { get; set; }
    }
}
