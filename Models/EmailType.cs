using System;
using System.Collections.Generic;

namespace Nbn.eCommenrce.ItemService.Models
{
    public partial class EmailType
    {
        public int EmailTypeId { get; set; }
        public string EmailTypeName { get; set; }
        public string EmailTypeAddedBy { get; set; }
        public DateTime? EmailTypeAddedWhen { get; set; }
        public string EmailTypeUpdatedBy { get; set; }
        public DateTime? EmailTypeUpdatedWhen { get; set; }
    }
}
