using System;
using System.Collections.Generic;

namespace Nbn.eCommenrce.ItemService.Models
{
    public partial class SalesContractKitchenAccessories
    {
        public int SalesContractAccessoryId { get; set; }
        public int? SalesContractKitchenDetailId { get; set; }
        public int? SalesContractId { get; set; }
        public string ScaccessoryType { get; set; }
        public int? ScaccessoryApplianceTypeId { get; set; }
        public string ScaccessoryApplianceTypeName { get; set; }
        public string ScaccessoryApplianceCode { get; set; }
        public decimal? ScaccessoryApplianceQty { get; set; }
        public DateTime? ScaccessoryAddedWhen { get; set; }
        public string ScaccessoryAddedBy { get; set; }
        public DateTime? ScaccessoryUpdatedWhen { get; set; }
        public string ScaccessoryUpdatedBy { get; set; }

        public virtual SalesContractMaster SalesContract { get; set; }
        public virtual SalesContractKitchenDetails SalesContractKitchenDetail { get; set; }
    }
}
