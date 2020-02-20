using System;
using System.Collections.Generic;

namespace Nbn.eCommenrce.ItemService.Models
{
    public partial class CustomerCreditDetailPayments
    {
        public long CcdpaymentId { get; set; }
        public int? CustCreditId { get; set; }
        public int? InvPaymentId { get; set; }
        public DateTime? CcppaymentAddedWhen { get; set; }
        public string CcppaymentAddedBy { get; set; }
    }
}
