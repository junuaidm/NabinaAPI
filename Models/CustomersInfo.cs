using System;
using System.Collections.Generic;

namespace Nbn.eCommenrce.ItemService.Models
{
    public partial class CustomersInfo
    {
        public int CustomerId { get; set; }
        public string CustomerAccntCode { get; set; }
        public string CustomerCrno { get; set; }
        public string CustomerName { get; set; }
        public int? CustomerType { get; set; }
        public string CustomerAdd1 { get; set; }
        public string CustomerAdd2 { get; set; }
        public string CustomerTelNo { get; set; }
        public string CustomerMobile { get; set; }
        public string CustomerFaxNo { get; set; }
        public int? CustomerCountry { get; set; }
        public string CustomerWebSite { get; set; }
        public string CustomerEmail { get; set; }
        public string CustomerNob { get; set; }
        public string CustomerRegNo { get; set; }
        public DateTime? CustomerExpiryDate { get; set; }
        public int? CustomerCreditLimit { get; set; }
        public DateTime? CustomerRegDate { get; set; }
        public DateTime? CustomerCreditPeriod { get; set; }
        public string CustomerSecurity { get; set; }
        public int? CustomerPobox { get; set; }
        public byte? CustomerStatus { get; set; }
        public string CustomerAddedBy { get; set; }
        public DateTime? CustomerAddedWhen { get; set; }
        public string CustomerUpdatedBy { get; set; }
        public DateTime? CustomerUpdatedWhen { get; set; }
    }
}
