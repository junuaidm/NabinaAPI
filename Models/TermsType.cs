using System;
using System.Collections.Generic;

namespace Nbn.eCommenrce.ItemService.Models
{
    public partial class TermsType
    {
        public int TermsTypeId { get; set; }
        public string TermsTypeName { get; set; }
        public bool? TermsTypeActive { get; set; }
        public string TermsTypeAddedBy { get; set; }
        public DateTime? TermsTypeAddedWhen { get; set; }
        public string TermsTypeUpdatedBy { get; set; }
        public DateTime? TermsTypeUpdatedWhen { get; set; }
    }
}
