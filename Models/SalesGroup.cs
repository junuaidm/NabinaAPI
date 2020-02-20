using System;
using System.Collections.Generic;

namespace Nbn.eCommenrce.ItemService.Models
{
    public partial class SalesGroup
    {
        public SalesGroup()
        {
            SalesGroupDiscount = new HashSet<SalesGroupDiscount>();
            SalesPersons = new HashSet<SalesPersons>();
        }

        public int SalesGroupId { get; set; }
        public int? RoleId { get; set; }
        public string SalesGroupName { get; set; }
        public string SalesGroupDesc { get; set; }
        public int? SalesGroupParent { get; set; }
        public int? SalesGroupLeader { get; set; }
        public int? SalesGroupDiscountLeader { get; set; }
        public bool? SalesGroupCanEdit { get; set; }
        public decimal? SalesGroupMaxDiscount { get; set; }
        public bool? SalesGroupIsActive { get; set; }
        public bool? SalesGroupIsShowroomSales { get; set; }
        public string SalesGroupAddedBy { get; set; }
        public DateTime? SalesGroupAddedWhen { get; set; }
        public string SalesGroupUpdatedBy { get; set; }
        public DateTime? SalesGroupUpdatedWhen { get; set; }

        public virtual RolesInfo Role { get; set; }
        public virtual ICollection<SalesGroupDiscount> SalesGroupDiscount { get; set; }
        public virtual ICollection<SalesPersons> SalesPersons { get; set; }
    }
}
