using System;
using System.Collections.Generic;

namespace Nbn.eCommenrce.ItemService.Models
{
    public partial class CardsRegister
    {
        public int Crid { get; set; }
        public DateTime? Crdate { get; set; }
        public int? CardsId { get; set; }
        public int? SalesCreditInvoiceId { get; set; }
        public int? SalesReceiptId { get; set; }
        public int? CashCustomerId { get; set; }
        public int? CustomerId { get; set; }
        public string CrcardNo { get; set; }
        public string CrcardBankName { get; set; }
        public decimal? CrcardAmount { get; set; }
        public decimal? CrcardServiceChargePercentage { get; set; }
        public decimal? CrcardServiceChargeAmount { get; set; }
        public decimal? CrcardActualServiceChargePercentage { get; set; }
        public decimal? CrcardActualServiceChargeAmount { get; set; }
        public DateTime? CrclearDate { get; set; }
        public int? Crstatus { get; set; }
        public string Crremarks { get; set; }
        public string CraddedBy { get; set; }
        public DateTime? CraddedWhen { get; set; }
        public string CrupdatedBy { get; set; }
        public DateTime? CrupdatedWhen { get; set; }
    }
}
