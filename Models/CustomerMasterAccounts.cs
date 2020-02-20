using System;
using System.Collections.Generic;

namespace Nbn.eCommenrce.ItemService.Models
{
    public partial class CustomerMasterAccounts
    {
        public int CustMasterAccountId { get; set; }
        public string CustMasterAccountCode { get; set; }
        public string CustMasterAccountName { get; set; }
        public string CustomerAddress { get; set; }
        public string CustomerTelephone { get; set; }
        public string CustomerFax { get; set; }
        public string CustomerEmail { get; set; }
        public decimal? CustomerMaximumCreditLimit { get; set; }
        public int? CustMasterAccountStatus { get; set; }
        public string CustMasterAccountNotes { get; set; }
        public string CustMasterAccountAddedBy { get; set; }
        public DateTime? CustMasterAccountAddedWhen { get; set; }
        public string CustMasterAccountUpdatedBy { get; set; }
        public DateTime? CustMasterAccountUpdatedWhen { get; set; }
    }
}
