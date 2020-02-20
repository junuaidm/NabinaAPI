using System;
using System.Collections.Generic;

namespace Nbn.eCommenrce.ItemService.Models
{
    public partial class FormOfPayments
    {
        public int Fopid { get; set; }
        public string Fopname { get; set; }
        public string FopaddedBy { get; set; }
        public DateTime? FopaddedWhen { get; set; }
        public string FopupdatedBy { get; set; }
        public DateTime? FopupdatedWhen { get; set; }
    }
}
