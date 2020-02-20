using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Nbn.eCommenrce.ItemService.Models
{
    public partial class CustomerEnquiries
    {
        public CustomerEnquiries()
        {
            SalesQuotation = new HashSet<SalesQuotation>();
        }
        [Key]
        public int CustEnquiryId { get; set; }
        public string CustEnqCode { get; set; }
        public int? ProjectId { get; set; }
        public int? CustAccntId { get; set; }
        public int? CustomerId { get; set; }
        public int? SalesPersonId { get; set; }
        public string CustEnqCustName { get; set; }
        public string CustEnqAdd1 { get; set; }
        public string CustEnqAdd2 { get; set; }
        public string CustEnqTelephone { get; set; }
        public string CustEnqMobile { get; set; }
        public string CustEnqFax { get; set; }
        public string CustEnqEmail { get; set; }
        public string CustEnqContactPersonName { get; set; }
        public string CustEnqDesignation { get; set; }
        public string CustEnqProjectName { get; set; }
        public string CustEnqReReference { get; set; }
        public DateTime? CustEnqReceivedDate { get; set; }
        public string CustEnqDescription { get; set; }
        public DateTime? CustEnqAssignedOn { get; set; }
        public bool? CustEnqIsActive { get; set; }
        public bool? CustEnqIsClosed { get; set; }
        public DateTime? CustEnqClosingDate { get; set; }
        public string CustEnqClosedBy { get; set; }
        public string CustEnqClosingReason { get; set; }
        public string CustEnqAddedBy { get; set; }
        public DateTime? CustEnqAddedWhen { get; set; }
        public string CustEnqUpdatedBy { get; set; }
        public DateTime? CustEnqUpdatedWhen { get; set; }

        public virtual CustomerMaster Customer { get; set; }
        public virtual Projects Project { get; set; }
        public virtual SalesPersons SalesPerson { get; set; }
        public virtual ICollection<SalesQuotation> SalesQuotation { get; set; }
    }
}
