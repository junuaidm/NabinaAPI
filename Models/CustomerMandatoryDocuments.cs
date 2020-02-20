using System;
using System.Collections.Generic;

namespace Nbn.eCommenrce.ItemService.Models
{
    public partial class CustomerMandatoryDocuments
    {
        public int MandatoryDocumentId { get; set; }
        public string MandatoryDocumentName { get; set; }
        public int? CustomerType { get; set; }
        public string ModeOfPayment { get; set; }
        public bool? MandatoryDocumentIsActive { get; set; }
    }
}
