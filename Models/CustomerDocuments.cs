using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Nbn.eCommenrce.ItemService.Models
{
    public partial class CustomerDocuments
    {
        [Key]
        public int CustDocId { get; set; }
        public int? CustomerId { get; set; }
        public string CustDocName { get; set; }
        public int? CustDocTypeId { get; set; }
        public string CustDocDesc { get; set; }
        public string CustDocFileType { get; set; }
        public string CustDocFileName { get; set; }
        public bool? CustDocIsActive { get; set; }
        public string CustDocAddedBy { get; set; }
        public DateTime? CustDocAddedWhen { get; set; }
        public string CustDocUpdatedBy { get; set; }
        public DateTime? CustDocUpdatedWhen { get; set; }

        public virtual CustomerMaster Customer { get; set; }
    }
}
