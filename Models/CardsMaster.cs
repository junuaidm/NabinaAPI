using System;
using System.Collections.Generic;

namespace Nbn.eCommenrce.ItemService.Models
{
    public partial class CardsMaster
    {
        public int CardsId { get; set; }
        public string CardsName { get; set; }
        public decimal? CardsServiceChargePercentage { get; set; }
        public bool? CardsIsActive { get; set; }
        public string CardsAddedBy { get; set; }
        public DateTime? CardsAddedWhen { get; set; }
        public string CardsUpdatedBy { get; set; }
        public DateTime? CardsUpdatedWhen { get; set; }
    }
}
