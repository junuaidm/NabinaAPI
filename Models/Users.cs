using System;
using System.Collections.Generic;

namespace Nbn.eCommenrce.ItemService.Models
{
    public partial class Users
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string LoginName { get; set; }
        public string LoginPassword { get; set; }
        public bool? UserStatus { get; set; }
        public int? EmpId { get; set; }
        public string UserEmailId { get; set; }
        public int? ManagerUserId { get; set; }
        public string UserAddedBy { get; set; }
        public DateTime? UserAddedWhen { get; set; }
        public string UserUpdatedBy { get; set; }
        public DateTime? UserUpdatedWhen { get; set; }
    }
}
