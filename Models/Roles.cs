using System;
using System.Collections.Generic;

namespace Nbn.eCommenrce.ItemService.Models
{
    public partial class Roles
    {
        public int RoleId { get; set; }
        public string RoleName { get; set; }
        public string RoleDescription { get; set; }
        public int? RoleParentId { get; set; }
        public int? DefaultUserId { get; set; }
        public bool? RoleStatus { get; set; }
        public string RoleAddedBy { get; set; }
        public DateTime? RoleAddedWhen { get; set; }
        public string RoleUpdatedBy { get; set; }
        public DateTime? RoleUpdatedWhen { get; set; }
    }
}
