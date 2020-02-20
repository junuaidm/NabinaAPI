using System;
using System.Collections.Generic;

namespace Nbn.eCommenrce.ItemService.Models
{
    public partial class StoreIssueVoucherDetail
    {
        public StoreIssueVoucherDetail()
        {
            DeliveryNoteDetail = new HashSet<DeliveryNoteDetail>();
        }

        public int SivdetailId { get; set; }
        public int? Sivid { get; set; }
        public int? SlcashInvoiceDetailId { get; set; }
        public int? SlcreditInvoiceDetailId { get; set; }
        public int? SlmockupInvoiceDetailId { get; set; }
        public int? SlsampleInvoiceDetailId { get; set; }
        public int? MemitemIssuedId { get; set; }
        public int? SetId { get; set; }
        public int? IsdetailId { get; set; }
        public int? ItemId { get; set; }
        public decimal? SivdetailBaseUnitQty { get; set; }
        public int? SivdetailBaseUnitId { get; set; }
        public decimal? SivdetailItemSetQty { get; set; }
        public decimal? SivdetailItemQty { get; set; }
        public decimal? SivdetailItemActualQty { get; set; }
        public decimal? SivdetailItemDeliveredQty { get; set; }
        public decimal? SivdetailItemDeliveredActualQty { get; set; }
        public int? SivdetailSerialNo { get; set; }
        public string SivdetailAddedBy { get; set; }
        public DateTime? SivdetailAddedWhen { get; set; }
        public string SivdetailUpdatedBy { get; set; }
        public DateTime? SivdetailUpdatedWhen { get; set; }

        public virtual Items Item { get; set; }
        public virtual StoreIssueVoucherMaster Siv { get; set; }
        public virtual ICollection<DeliveryNoteDetail> DeliveryNoteDetail { get; set; }
    }
}
