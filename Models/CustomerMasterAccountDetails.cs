using System;
using System.Collections.Generic;

namespace Nbn.eCommenrce.ItemService.Models
{
    public partial class CustomerMasterAccountDetails
    {
        public int CustomerMasterAccountDetailId { get; set; }
        public int? CustMasterAccountId { get; set; }
        public int? CustomerId { get; set; }
        public string CustomerMasterAccountDetailAddedBy { get; set; }
        public DateTime? CustomerMasterAccountDetailAddedWhen { get; set; }
        public string CustomerMasterAccountDetailUpdatedBy { get; set; }
        public DateTime? CustomerMasterAccountDetailUpdatedWhen { get; set; }
    }
}
