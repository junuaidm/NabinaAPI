using System;
using System.Collections.Generic;

namespace Nbn.eCommenrce.ItemService.Models
{
    public partial class SalesReturnConfirmationMaster
    {
        public SalesReturnConfirmationMaster()
        {
            Memmaster = new HashSet<Memmaster>();
        }

        public int Srcid { get; set; }
        public string Srcno { get; set; }
        public int? Sivid { get; set; }
        public string SrcdeliveryNoteNo { get; set; }
        public DateTime? SrcreturnedDate { get; set; }
        public string Srcremarks { get; set; }
        public int? Srcstatus { get; set; }
        public string SrcaddedBy { get; set; }
        public DateTime? SrcaddedWhen { get; set; }
        public string SrcupdatedBy { get; set; }
        public DateTime? SrcupdatedWhen { get; set; }

        public virtual StoreIssueVoucherMaster Siv { get; set; }
        public virtual ICollection<Memmaster> Memmaster { get; set; }
    }
}
