using System;
using System.Collections.Generic;

namespace Nbn.eCommenrce.ItemService.Models
{
    public partial class Srmmaster
    {
        public Srmmaster()
        {
            SrmreturnedItems = new HashSet<SrmreturnedItems>();
        }

        public int Srmid { get; set; }
        public string Srmcode { get; set; }
        public DateTime? Srmdate { get; set; }
        public int? Srmtype { get; set; }
        public int? InvoiceItemCategoryId { get; set; }
        public int? Srcid { get; set; }
        public int? Sivid { get; set; }
        public int? Memid { get; set; }
        public int? SalesCashInvoiceId { get; set; }
        public int? SalesCreditInvoiceId { get; set; }
        public int? SalesSampleInvoiceId { get; set; }
        public int? SalesMockupInvoiceId { get; set; }
        public int? SalesPersonId { get; set; }
        public int? CustomerId { get; set; }
        public int? CustAccntId { get; set; }
        public int? CashCustomerId { get; set; }
        public string Srmreason { get; set; }
        public string Srmrecommendation { get; set; }
        public decimal? SrmfixingCharge { get; set; }
        public decimal? SrmtotalReturnedDeliveyCharge { get; set; }
        public decimal? SrmtotalReturnedAmount { get; set; }
        public int? Srmstatus { get; set; }
        public string Srmremarks { get; set; }
        public bool? SrmisPrinted { get; set; }
        public string Srmaddedby { get; set; }
        public DateTime? SrmaddedWhen { get; set; }
        public string Srmupdatedby { get; set; }
        public DateTime? SrmupdatedWhen { get; set; }

        public virtual ICollection<SrmreturnedItems> SrmreturnedItems { get; set; }
    }
}
