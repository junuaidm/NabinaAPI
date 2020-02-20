using System;
using System.Collections.Generic;

namespace Nbn.eCommenrce.ItemService.Models
{
    public partial class SalesContractPaymentType
    {
        public int SalesContractPaymentTypeId { get; set; }
        public string SalesContractPaymentTypeName { get; set; }
        public string SalesContractPaymentTypeNameArabic { get; set; }
        public int? SalesContractPaymentTypeStatus { get; set; }
        public DateTime? SalesContractPaymentAddedWhen { get; set; }
        public string SalesContractPaymentAddedBy { get; set; }
        public DateTime? SalesContractPaymentUpdatedWhen { get; set; }
        public string SalesContractPaymentUpdatedBy { get; set; }
    }
}
