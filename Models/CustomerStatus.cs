using System;
using System.Collections.Generic;

namespace Nbn.eCommenrce.ItemService.Models
{
    public partial class CustomerStatus
    {
        public int CustStatusId { get; set; }
        public string CustStatusName { get; set; }
        public string CustStatusDesc { get; set; }
        public bool? CustStatusIsActive { get; set; }
        public bool? CustStatusAllowedInvoicing { get; set; }
        public bool? CustStatusNonEditable { get; set; }
        public string CustStatusAddedBy { get; set; }
        public DateTime? CustStatusAddedWhen { get; set; }
        public string CustStatusUpdatedBy { get; set; }
        public DateTime? CustStatusUpdatedWhen { get; set; }
    }
}
