using System;
using System.Collections.Generic;

namespace Nbn.eCommenrce.ItemService.Models
{
    public partial class CostCentre
    {
        public CostCentre()
        {
            Items = new HashSet<Items>();
        }

        public int CostCentreId { get; set; }
        public string CostCentreName { get; set; }
        public string CostCentreDescription { get; set; }
        public bool? CostCentreActive { get; set; }
        public bool? CostCentreIsKitchenItems { get; set; }
        public string CostCentreAddedBy { get; set; }
        public DateTime? CostCentreAddedWhen { get; set; }
        public string CostCentreUpdatedBy { get; set; }
        public DateTime? CostCentreUpdatedWhen { get; set; }

        public virtual ICollection<Items> Items { get; set; }
    }
}
