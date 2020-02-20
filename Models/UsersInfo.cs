using System;
using System.Collections.Generic;

namespace Nbn.eCommenrce.ItemService.Models
{
    public partial class UsersInfo
    {
        public int UserId { get; set; }
        public string UserUsername { get; set; }
        public string UserPassword { get; set; }
        public string UserEmail { get; set; }
        public byte? UserStatus { get; set; }
        public int? EmpId { get; set; }
        public string AppId { get; set; }
        public string RoleId { get; set; }
        public byte? UserPriority { get; set; }
        public string UserAddedby { get; set; }
        public DateTime? UserAddeddate { get; set; }
        public string UserUpdatedby { get; set; }
        public DateTime? UserUpdateddate { get; set; }
    }
}
