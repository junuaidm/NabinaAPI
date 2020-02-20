using System;
using System.Collections.Generic;

namespace Nbn.eCommenrce.ItemService.Models
{
    public partial class SalesContractPaymentTerms
    {
        public int SalesContractPaymentTermId { get; set; }
        public string SalesContractPaymentTermName { get; set; }
        public string SalesContractPaymentTermNameArabic { get; set; }
        public bool? SalesContractPaymentTermIsActive { get; set; }
        public DateTime? SalesContractPaymentTermAddedWhen { get; set; }
        public string SalesContractPaymentTermAddedBy { get; set; }
        public DateTime? SalesContractPaymentTermUpdatedWhen { get; set; }
        public string SalesContractPaymentTermUpdatedBy { get; set; }
    }
}
