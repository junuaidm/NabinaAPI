using System;
using System.Collections.Generic;

namespace Nbn.eCommenrce.ItemService.Models
{
    public partial class DeliveryNoteMaster
    {
        public DeliveryNoteMaster()
        {
            DeliveryNoteDetail = new HashSet<DeliveryNoteDetail>();
            DeliveryNoteItemDetail = new HashSet<DeliveryNoteItemDetail>();
        }

        public int DeliveryNoteId { get; set; }
        public string DeliveryNoteCode { get; set; }
        public DateTime? DeliveryNoteDate { get; set; }
        public int? Sivid { get; set; }
        public int? SalesCashInvoiceId { get; set; }
        public int? SalesCreditInvoiceId { get; set; }
        public int? SalesSampleInvoiceId { get; set; }
        public int? SalesMockupInvoiceId { get; set; }
        public int? Memid { get; set; }
        public int? CustomerId { get; set; }
        public int? CashCustomerId { get; set; }
        public int? SalesPersonId { get; set; }
        public int? InChargeId { get; set; }
        public int? DeliveryTypeId { get; set; }
        public string DeliveryNoteItemsReceivedBy { get; set; }
        public int? DeliveryNoteReceiverTypeId { get; set; }
        public int? ForemanId { get; set; }
        public string DeliveryNoteDeliveryVehicleNo { get; set; }
        public string DeliveryNoteRemarks { get; set; }
        public int? DeliveryNoteStatus { get; set; }
        public string DeliveryNoteDeliveryAddress { get; set; }
        public bool? DeliveryNotePrinted { get; set; }
        public bool? IsLcdeliveryNote { get; set; }
        public string DeliveryNoteAddedBy { get; set; }
        public DateTime? DeliveryNoteAddedWhen { get; set; }
        public string DeliveryNoteUpdatedBy { get; set; }
        public DateTime? DeliveryNoteUpdatedWhen { get; set; }

        public virtual Memmaster Mem { get; set; }
        public virtual SalesCashInvoiceMaster SalesCashInvoice { get; set; }
        public virtual SalesCreditInvoiceMaster SalesCreditInvoice { get; set; }
        public virtual SalesMockupInvoiceMaster SalesMockupInvoice { get; set; }
        public virtual SalesSampleInvoiceMaster SalesSampleInvoice { get; set; }
        public virtual StoreIssueVoucherMaster Siv { get; set; }
        public virtual ICollection<DeliveryNoteDetail> DeliveryNoteDetail { get; set; }
        public virtual ICollection<DeliveryNoteItemDetail> DeliveryNoteItemDetail { get; set; }
    }
}
