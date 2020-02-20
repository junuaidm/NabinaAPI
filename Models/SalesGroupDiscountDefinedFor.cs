using System;
using System.Collections.Generic;

namespace Nbn.eCommenrce.ItemService.Models
{
    public partial class SalesGroupDiscountDefinedFor
    {
        public SalesGroupDiscountDefinedFor()
        {
            SalesGroupDiscount = new HashSet<SalesGroupDiscount>();
        }

        public int DefinedForId { get; set; }
        public string DefinedForName { get; set; }

        public virtual ICollection<SalesGroupDiscount> SalesGroupDiscount { get; set; }
    }
}
