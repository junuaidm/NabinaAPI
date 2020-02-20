using System;
using System.Collections.Generic;

namespace Nbn.eCommenrce.ItemService.Models
{
    public partial class ChequeRegisterDetail
    {
        public int CrdetailId { get; set; }
        public int? ChequeRegisterId { get; set; }
        public DateTime? ChequeRegisterChequeDepositedDate { get; set; }
        public DateTime? ChequeRegisterChequeCleareDate { get; set; }
        public DateTime? ChequeRegisterChequeBouncedDate { get; set; }
        public int? VoucherId { get; set; }
        public int? VoucherDetailId { get; set; }
        public int? CrdetailStatus { get; set; }
        public string CrdetailAddedBy { get; set; }
        public DateTime? CrdetailAddedWhen { get; set; }
        public string CrdetailUpdatedBy { get; set; }
        public DateTime? CrdetailUpdatedWhen { get; set; }
    }
}
