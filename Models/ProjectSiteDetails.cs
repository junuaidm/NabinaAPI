using System;
using System.Collections.Generic;

namespace Nbn.eCommenrce.ItemService.Models
{
    public partial class ProjectSiteDetails
    {
        public int ProjectSiteId { get; set; }
        public int? ProjectId { get; set; }
        public string ProjectSiteName { get; set; }
        public string ProjectSiteContactName { get; set; }
        public string ProjectSitePobox { get; set; }
        public string ProjectSiteStreet { get; set; }
        public string ProjectSiteArea { get; set; }
        public string ProjectSiteCity { get; set; }
        public string ProjectSiteAddress { get; set; }
        public string ProjectSiteTelephone { get; set; }
        public string ProjectSiteMobile { get; set; }
        public string ProjectSiteFax { get; set; }
        public string ProjectSiteEmail { get; set; }
        public string ProjectSiteAddedBy { get; set; }
        public DateTime? ProjectSiteAddedWhen { get; set; }
        public string ProjectSiteUpdatedBy { get; set; }
        public DateTime? ProjectSiteUpdatedWhen { get; set; }
    }
}
