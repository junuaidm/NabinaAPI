using System;
using System.Collections.Generic;

namespace Nbn.eCommenrce.ItemService.Models
{
    public partial class SalesContractWardrobeDetails
    {
        public int SalesContractWardrobeDetailId { get; set; }
        public int SalesContractId { get; set; }
        public bool? ScwmodelIsSliding { get; set; }
        public bool? ScwmodelIsNormal { get; set; }
        public bool? ScwtypeIsPvc { get; set; }
        public bool? ScwtypeIsCliff { get; set; }
        public bool? ScwdesignIsPlain { get; set; }
        public bool? ScwdesignIsMilano { get; set; }
        public string ScwdoorColor { get; set; }
        public bool? ScwdoorIsWithMirror { get; set; }
        public bool? ScwdoorIsWithOutMirror { get; set; }
        public bool? ScwdoorIsGlassDoor { get; set; }
        public bool? ScwdoorIsMixed { get; set; }
        public string ScwcarcaseColor { get; set; }
        public bool? ScwcorniceIsTop { get; set; }
        public bool? ScwisWithOutCornice { get; set; }
        public string Scwhandle { get; set; }
        public string Scwskirting { get; set; }
        public bool? ScwisWithShoeRack { get; set; }
        public bool? ScwisWithHanger { get; set; }
        public bool? ScwisWithExtraShelves { get; set; }
        public decimal? ScwextraShelfQty { get; set; }
        public bool? ScwisWithDressingTable { get; set; }
        public decimal? ScwdressingTableQty { get; set; }
        public bool? ScwisWithAdditionalAccessories { get; set; }
        public string ScwadditionalAccessoryDetails { get; set; }
        public string ScwremarksOne { get; set; }
        public string ScwremarksTwo { get; set; }
        public string ScwaddedBy { get; set; }
        public DateTime? ScwaddedWhen { get; set; }
        public string ScwupdatedBy { get; set; }
        public DateTime? ScwupdatedWhen { get; set; }

        public virtual SalesContractMaster SalesContract { get; set; }
    }
}
