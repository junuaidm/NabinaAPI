using System;
using System.Collections.Generic;

namespace Nbn.eCommenrce.ItemService.Models
{
    public partial class ItemAttributes
    {
        public int AttributeId { get; set; }
        public string AttribArtNo { get; set; }
        public int ItemId { get; set; }
        public decimal? AttribTonality { get; set; }
        public int? AttribBatchNo { get; set; }
        public int? AttribProductionNo { get; set; }
        public string AttribManufacturersCode { get; set; }
        public decimal? AttribQty { get; set; }
        public decimal? AttribRemovedQty { get; set; }
        public string AttribShade { get; set; }
        public string AttribCaliber { get; set; }
        public string AttribHeight { get; set; }
        public string AttribLength { get; set; }
        public string AttribBreadth { get; set; }
        public string AttribWeigth { get; set; }
        public string AttribVolume { get; set; }
        public string AttribMaxShelfLife { get; set; }
        public string AttribMaxTemp { get; set; }
        public string AttribMinTemp { get; set; }
        public DateTime? AttribExpiryDate { get; set; }
        public int? StorageAreaId { get; set; }
        public int? Mrcid { get; set; }
        public int? Srvid { get; set; }
        public string AttribAddedBy { get; set; }
        public DateTime? AttribAddedWhen { get; set; }
        public string AttribUpdatedBy { get; set; }
        public DateTime? AttribUpdatedWhen { get; set; }

        public virtual Items Item { get; set; }
    }
}
