using System;
using System.Collections.Generic;

namespace Nbn.eCommenrce.ItemService.Models
{
    public partial class SalesContractKitchenDetails
    {
        public SalesContractKitchenDetails()
        {
            SalesContractKitchenAccessories = new HashSet<SalesContractKitchenAccessories>();
        }

        public int SalesContractKitchenDetailId { get; set; }
        public int? SalesContractId { get; set; }
        public string SckdetailType { get; set; }
        public string SckdetailDesign { get; set; }
        public decimal? SckdetailQty { get; set; }
        public string SckdetailDoorColor { get; set; }
        public bool? SckdetailCarcaseIsWhite { get; set; }
        public bool? SckdetailCarcaseIsColor { get; set; }
        public string SckdetailCarcaseColor { get; set; }
        public bool? SckdetailCorniceIsTop { get; set; }
        public bool? SckdetailCorniceIsBottom { get; set; }
        public bool? SckdetailCorniceIsTopBox { get; set; }
        public bool? SckdetailCorniceIsWithOut { get; set; }
        public bool? SckdetailSkirtingIsWithOut { get; set; }
        public bool? SckdetailSkirtingIsMoonstone { get; set; }
        public string SckdetailSkirtingMoonstoneColor { get; set; }
        public bool? SckdetailSkirtingIsStsteel { get; set; }
        public string SckdetailSkirtingStsteelHeight { get; set; }
        public bool? SckdetailSkirtingIsGlassType { get; set; }
        public bool? SckdetailSkirtingIsPlasticPlinth { get; set; }
        public bool? SckdetailSkirtingIsArtMarble { get; set; }
        public bool? SckdetailSkirtingIsEndBaseEndWall { get; set; }
        public bool? SckdetailSkirtingEndIsWout { get; set; }
        public bool? SckdetailSkirtingIsWoutRail { get; set; }
        public bool? SckdetailSkirtingIsWithRail { get; set; }
        public string SckdetailSkirtingWithRailColor { get; set; }
        public string SckdetailHandleCodes { get; set; }
        public bool? SckdetailWorktopIsWithOut { get; set; }
        public string SckdetailWorktopType { get; set; }
        public string SckdetailWorktopColor { get; set; }
        public string SckdetailMixerCodes { get; set; }
        public bool? SckdetailIsSinkStSteel { get; set; }
        public bool? SckdetailIsSinkMoonstone { get; set; }
        public bool? SckdetailIsSinkSingle { get; set; }
        public bool? SckdetailIsSinkDouble { get; set; }
        public string SckdetailSinkCodes { get; set; }
        public string SckdetailSinkMoonstoneColor { get; set; }
        public bool? SckdetailIsColStSteel { get; set; }
        public bool? SckdetailIsColMoonstone { get; set; }
        public string SckdetailColCodes { get; set; }
        public string SckdetailColMoonstoneColor { get; set; }
        public string SckitchenAccessoryDetails { get; set; }
        public string SckitchenAccessoryDetailsArabic { get; set; }
        public string SckitchenOtherDetails { get; set; }
        public string SckitchenOtherDetailsArabic { get; set; }
        public DateTime SckdetailAddedWhen { get; set; }
        public string SckdetailAddedBy { get; set; }
        public DateTime? SckdetailUpdatedWhen { get; set; }
        public string SckdetailUpdatedBy { get; set; }

        public virtual SalesContractMaster SalesContract { get; set; }
        public virtual ICollection<SalesContractKitchenAccessories> SalesContractKitchenAccessories { get; set; }
    }
}
