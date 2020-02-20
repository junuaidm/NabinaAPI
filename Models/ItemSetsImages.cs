using System;
using System.Collections.Generic;

namespace Nbn.eCommenrce.ItemService.Models
{
    public partial class ItemSetsImages
    {
        public int SetImgId { get; set; }
        public int? SetId { get; set; }
        public string SetImgName { get; set; }
        public byte[] SetImage { get; set; }
        public byte[] SetThumbnailImage { get; set; }
        public string ImageType { get; set; }
        public long? ImageSize { get; set; }
        public string SetImgDesc { get; set; }
        public bool? SetImgIsActive { get; set; }
        public bool? SetImgDefault { get; set; }
        public string SetImgAddedBy { get; set; }
        public DateTime? SetImgAddedWhen { get; set; }
        public string SetImgUpdatedBy { get; set; }
        public DateTime? SetImgUpdateWhen { get; set; }

        public virtual ItemSets Set { get; set; }
    }
}
