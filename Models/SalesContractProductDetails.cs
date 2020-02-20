using System;
using System.Collections.Generic;

namespace Nbn.eCommenrce.ItemService.Models
{
    public partial class SalesContractProductDetails
    {
        public int SalesContractProductDetailId { get; set; }
        public int? SalesContractId { get; set; }
        public string SalesContractProductLocation { get; set; }
        public decimal? SalesContractProductQty { get; set; }
        public string SalesContractProductDescription { get; set; }
        public DateTime? SalesContractProductAddedWhen { get; set; }
        public string SalesContractProductAddedBy { get; set; }
        public DateTime? SalesContractProductUpdatedWhen { get; set; }
        public string SalesContractProductUpdatedBy { get; set; }

        public virtual SalesContractMaster SalesContract { get; set; }
    }
}
