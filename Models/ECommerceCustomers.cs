using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nbn.eCommenrce.ItemService.Models
{
    public class ECommerceCustomers
    {
        public int ECommerceCustomerID { get; set; }
        public string ECCustomerName { get; set; }
        public string ECCustomerPOBox { get; set; }
        public string ECCustomerAddress1 { get; set; }
        public string ECCustomeraddress2 { get; set; }
        public string ECCustomerTelephone { get; set; }
        public string ECCustomerMobile { get; set; }
        public string ECCustomerFax { get; set; }
        public string ECCustomerEmail { get; set; }
        public string ECCustomerPassword { get; set; }
        public string ECCustomerLastLoginTime { get; set; }
        public int NBMCustomerID { get; set; }
        public int NBMCashCustomerID { get; set; }
        public int KMCustomerID { get; set; }
        public int KMCashCustomerID { get; set; }
        public string ECCustomerContactPersonName { get; set; }
        public string ECCustomerDesignation { get; set; }
        public bool ECCustomerIsActive { get; set; }
        public int ECCustomerAddedBy { get; set; }
        public DateTime ECCustomerAddedWhen { get; set; }
        public int ECCustomerUpdatedBy { get; set; }
        public DateTime ECCustomerUpdatedWhen { get; set; }
    }
    public class testcustomer
    {
        public int id { get; set; } 
        public string Name { get; set; }
    }
}
