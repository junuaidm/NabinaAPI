using System;
using System.Collections.Generic;

namespace Nbn.eCommenrce.ItemService.Models
{
    public partial class SalesInvoiceTmpSiv
    {
        public int SalesInvoiceTmpSivdetailId { get; set; }
        public int? SalesInvoiceTmpSivid { get; set; }
        public string SalesInvoiceTmpSivname { get; set; }
        public int? SalesCashInvoiceId { get; set; }
        public int? SalesCreditInvoiceId { get; set; }
        public int? SalesSampleInvoiceId { get; set; }
        public int? SalesMockupInvoiceId { get; set; }
        public int? SetId { get; set; }
        public int? ItemId { get; set; }
        public string ItemDescription { get; set; }
        public decimal? SalesInvoiceTmpSivdetailQty { get; set; }
        public int? SalesInvoiceTmpSivdetailSerialNo { get; set; }
        public string SalesInvoiceTmpDeliveryLoc { get; set; }
        public string SalesInvoiceTmpDeliveryContactPerson { get; set; }
        public string SalesInvoiceTmpDeliveryContactNo { get; set; }
        public string SalesInvoiceTmpSivdetailAddedBy { get; set; }
        public DateTime? SalesInvoiceTmpSivdetailAddedWhen { get; set; }
        public string SalesInvoiceTmpSivdetailUpdatedBy { get; set; }
        public DateTime? SalesInvoiceTmpSivdetailUpdatedWhen { get; set; }
    }
}
