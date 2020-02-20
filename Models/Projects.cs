using System;
using System.Collections.Generic;

namespace Nbn.eCommenrce.ItemService.Models
{
    public partial class Projects
    {
        public Projects()
        {
            CustomerEnquiries = new HashSet<CustomerEnquiries>();
            ProjectDocuments = new HashSet<ProjectDocuments>();
            ProjectStakeHolders = new HashSet<ProjectStakeHolders>();
            SalesQuotation = new HashSet<SalesQuotation>();
        }

        public int ProjectId { get; set; }
        public string ProjectCode { get; set; }
        public int? ProjectTypeId { get; set; }
        public string ProjectName { get; set; }
        public int? CustomerId { get; set; }
        public string ProjectOthers { get; set; }
        public string ContactName { get; set; }
        public string PositionName { get; set; }
        public string ContactAddress1 { get; set; }
        public string ContactAddress2 { get; set; }
        public string ContactTelephone { get; set; }
        public string ContactFax { get; set; }
        public string ContactEmail { get; set; }
        public string ProjectReference { get; set; }
        public DateTime? ProjectReferenceDate { get; set; }
        public DateTime? ProjectActionDeadLine { get; set; }
        public DateTime? ProjectStartDate { get; set; }
        public DateTime? ProjectCompletionDate { get; set; }
        public string ProjectSupervisor { get; set; }
        public string ProjectNotes { get; set; }
        public DateTime? ProjectDate { get; set; }
        public string ContactMobile { get; set; }
        public int? SalesPersonId { get; set; }
        public decimal? ProjectValue { get; set; }
        public bool? ProjectIsActive { get; set; }
        public string ProjectAddedBy { get; set; }
        public DateTime? ProjectAddedWhen { get; set; }
        public string ProjectUpdatedBy { get; set; }
        public DateTime? ProjectUpdatedWhen { get; set; }

        public virtual CustomerMaster Customer { get; set; }
        public virtual ICollection<CustomerEnquiries> CustomerEnquiries { get; set; }
        public virtual ICollection<ProjectDocuments> ProjectDocuments { get; set; }
        public virtual ICollection<ProjectStakeHolders> ProjectStakeHolders { get; set; }
        public virtual ICollection<SalesQuotation> SalesQuotation { get; set; }
    }
}
