using System;
using System.Collections.Generic;

namespace Nbn.eCommenrce.ItemService.Models
{
    public partial class SalesContractDoorDetails
    {
        public int SalesContractDoorDetailId { get; set; }
        public int? SalesContractId { get; set; }
        public decimal? ScdoorQty { get; set; }
        public string ScdoorCategory { get; set; }
        public string ScdoorType { get; set; }
        public string ScdoorFireratedMinutes { get; set; }
        public string ScdoorFrame { get; set; }
        public string ScdoorArchitrave { get; set; }
        public string ScdoorDesignCode { get; set; }
        public string ScdoorColor { get; set; }
        public string ScdoorHandleCode { get; set; }
        public string ScdoorLockCode { get; set; }
        public string ScdoorHingesColor { get; set; }
        public bool? ScdoorHasShutter { get; set; }
        public bool? ScdoorHasFrame { get; set; }
        public bool? ScdoorHasArchitrave { get; set; }
        public string ScdoorOtherDetails { get; set; }
        public string ScdoorOtherDetailsArabic { get; set; }
        public DateTime? SalesContractAddedWhen { get; set; }
        public string SalesContractAddedBy { get; set; }
        public DateTime? SalesContractUpdatedWhen { get; set; }
        public string SalesContractUpdatedBy { get; set; }

        public virtual SalesContractMaster SalesContract { get; set; }
    }
}
