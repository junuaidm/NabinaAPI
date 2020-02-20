using System;
using System.Collections.Generic;

namespace Nbn.eCommenrce.ItemService.Models
{
    public partial class ItemImages
    {
        public ItemImages()
        {
            SalesQuotationDetails = new HashSet<SalesQuotationDetails>();
        }

        public int ItemImgId { get; set; }
        public int ItemId { get; set; }
        public string ItemImgName { get; set; }
        public byte[] ItemImage { get; set; }
        public byte[] ItemThumbImage { get; set; }
        public string ImageType { get; set; }
        public long? ImageSize { get; set; }
        public string ItemImgDesc { get; set; }
        public bool? ItemImgIsActive { get; set; }
        public string ItemImgAddedBy { get; set; }
        public DateTime? ItemImgAddedWhen { get; set; }
        public string ItemImgUpdatedBy { get; set; }
        public DateTime? ItemImgUpdatedWhen { get; set; }
        public bool? ItemImgDefault { get; set; }

        public virtual ICollection<SalesQuotationDetails> SalesQuotationDetails { get; set; }
    }
}
