using System;
using System.Collections.Generic;

namespace Nbn.eCommenrce.ItemService.Models
{
    public partial class Foreman
    {
        public int ForemanId { get; set; }
        public string ForemanName { get; set; }
        public int? EmployeeId { get; set; }
        public bool? ForemanIsActive { get; set; }
        public bool? IsSupervisor { get; set; }
        public string ForemanAddedBy { get; set; }
        public DateTime? ForemanAddedWhen { get; set; }
        public string ForemanUpdatedBy { get; set; }
        public DateTime? ForemanUpdatedWhen { get; set; }
    }
}
