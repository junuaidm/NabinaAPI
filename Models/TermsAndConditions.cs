using System;
using System.Collections.Generic;

namespace Nbn.eCommenrce.ItemService.Models
{
    public partial class TermsAndConditions
    {
        public TermsAndConditions()
        {
            SalesQuotation = new HashSet<SalesQuotation>();
        }

        public int TermsId { get; set; }
        public string TermsName { get; set; }
        public string TermsInEnglish { get; set; }
        public string TermsInArabic { get; set; }
        public byte[] TermsFile { get; set; }
        public string TermsFileType { get; set; }
        public string TermsDocuments { get; set; }
        public int? TermsTypeId { get; set; }
        public bool? TermsIsActive { get; set; }
        public long? TermsFileSize { get; set; }
        public string TermsAddedBy { get; set; }
        public DateTime? TermsAddedWhen { get; set; }
        public string TermsUpdatedBy { get; set; }
        public DateTime? TermsUpdatedWhen { get; set; }

        public virtual ICollection<SalesQuotation> SalesQuotation { get; set; }
    }
}
