using System;
using System.Collections.Generic;

namespace Nbn.eCommenrce.ItemService.Models
{
    public partial class SalesPersons
    {
        public SalesPersons()
        {
            CustomerEnquiries = new HashSet<CustomerEnquiries>();
            CustomerSalesPersons = new HashSet<CustomerSalesPersons>();
            SalesCashInvoiceMaster = new HashSet<SalesCashInvoiceMaster>();
            SalesCreditInvoiceMaster = new HashSet<SalesCreditInvoiceMaster>();
            SalesMockupInvoiceMaster = new HashSet<SalesMockupInvoiceMaster>();
            SalesQuotation = new HashSet<SalesQuotation>();
            SalesSampleInvoiceMaster = new HashSet<SalesSampleInvoiceMaster>();
        }

        public int SalesPersonId { get; set; }
        public int? EmpId { get; set; }
        public int? SalesGroupId { get; set; }
        public int? UserId { get; set; }
        public string SalesPersonTitle { get; set; }
        public string SalesPersonName { get; set; }
        public string SalesPersonShortName { get; set; }
        public string SalesPersonDesignation { get; set; }
        public string SalesPersonContactNo { get; set; }
        public string SalesPersonFaxNo { get; set; }
        public string SalesPersonExtNo { get; set; }
        public string SalesPersonEmail { get; set; }
        public string SalesPersonMobileNo { get; set; }
        public bool? SalesPersonIsActive { get; set; }
        public bool? SalesPersonIsCommon { get; set; }
        public bool? SalesPersonIsShowroom { get; set; }
        public string SalesPersonAddedBy { get; set; }
        public DateTime? SalesPersonAddedWhen { get; set; }
        public string SalesPersonUpdatedBy { get; set; }
        public DateTime? SalesPersonUpdatedWhen { get; set; }

        public virtual SalesGroup SalesGroup { get; set; }
        public virtual ICollection<CustomerEnquiries> CustomerEnquiries { get; set; }
        public virtual ICollection<CustomerSalesPersons> CustomerSalesPersons { get; set; }
        public virtual ICollection<SalesCashInvoiceMaster> SalesCashInvoiceMaster { get; set; }
        public virtual ICollection<SalesCreditInvoiceMaster> SalesCreditInvoiceMaster { get; set; }
        public virtual ICollection<SalesMockupInvoiceMaster> SalesMockupInvoiceMaster { get; set; }
        public virtual ICollection<SalesQuotation> SalesQuotation { get; set; }
        public virtual ICollection<SalesSampleInvoiceMaster> SalesSampleInvoiceMaster { get; set; }
    }
}
