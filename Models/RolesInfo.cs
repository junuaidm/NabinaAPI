using System;
using System.Collections.Generic;

namespace Nbn.eCommenrce.ItemService.Models
{
    public partial class RolesInfo
    {
        public RolesInfo()
        {
            SalesGroup = new HashSet<SalesGroup>();
        }

        public int RoleId { get; set; }
        public string RoleName { get; set; }
        public byte? RoleStatus { get; set; }
        public string MenuId { get; set; }
        public long? AppId { get; set; }

        public virtual ICollection<SalesGroup> SalesGroup { get; set; }
    }
}
