using System;
using System.Collections.Generic;

namespace Nbn.eCommenrce.ItemService.Models
{
    public partial class Units
    {
        public Units()
        {
            DeliveryNoteDetail = new HashSet<DeliveryNoteDetail>();
            DeliveryNoteItemDetailBaseUnit = new HashSet<DeliveryNoteItemDetail>();
            DeliveryNoteItemDetailUnit = new HashSet<DeliveryNoteItemDetail>();
            Items = new HashSet<Items>();
            SalesQuotationDetails = new HashSet<SalesQuotationDetails>();
            UnitOfConversionUnitIdfromNavigation = new HashSet<UnitOfConversion>();
            UnitOfConversionUnitIdtoNavigation = new HashSet<UnitOfConversion>();
            WhWareHouseStorageArea = new HashSet<WhWareHouseStorageArea>();
        }

        public int UnitId { get; set; }
        public string UnitName { get; set; }
        public string UnitSymbol { get; set; }
        public string UnitDesc { get; set; }
        public bool? UnitIsActive { get; set; }
        public string UnitAddedBy { get; set; }
        public DateTime? UnitAddedWhen { get; set; }
        public string UnitUpdatedBy { get; set; }
        public DateTime? UnitUpdatedWhen { get; set; }
        public byte? UnitIsDeleted { get; set; }

        public virtual ICollection<DeliveryNoteDetail> DeliveryNoteDetail { get; set; }
        public virtual ICollection<DeliveryNoteItemDetail> DeliveryNoteItemDetailBaseUnit { get; set; }
        public virtual ICollection<DeliveryNoteItemDetail> DeliveryNoteItemDetailUnit { get; set; }
        public virtual ICollection<Items> Items { get; set; }
        public virtual ICollection<SalesQuotationDetails> SalesQuotationDetails { get; set; }
        public virtual ICollection<UnitOfConversion> UnitOfConversionUnitIdfromNavigation { get; set; }
        public virtual ICollection<UnitOfConversion> UnitOfConversionUnitIdtoNavigation { get; set; }
        public virtual ICollection<WhWareHouseStorageArea> WhWareHouseStorageArea { get; set; }
    }
}
