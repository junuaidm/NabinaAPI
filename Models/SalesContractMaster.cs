using System;
using System.Collections.Generic;

namespace Nbn.eCommenrce.ItemService.Models
{
    public partial class SalesContractMaster
    {
        public SalesContractMaster()
        {
            SalesContractDoorDetails = new HashSet<SalesContractDoorDetails>();
            SalesContractKitchenAccessories = new HashSet<SalesContractKitchenAccessories>();
            SalesContractKitchenDetails = new HashSet<SalesContractKitchenDetails>();
            SalesContractProductDetails = new HashSet<SalesContractProductDetails>();
            SalesContractWardrobeDetails = new HashSet<SalesContractWardrobeDetails>();
        }

        public int SalesContractId { get; set; }
        public string SalesContractCode { get; set; }
        public DateTime? SalesContractDate { get; set; }
        public int? SalesContractSalesPersonId { get; set; }
        public DateTime? SalesContractGenerateDate { get; set; }
        public string SalesContractCustomerName { get; set; }
        public string SalesContractCustCrno { get; set; }
        public string SalesContractCustComputerNo { get; set; }
        public string SalesContractCustomerAddress { get; set; }
        public string SalesContractCustomerTelNo { get; set; }
        public string SalesContractCustomerMobNo { get; set; }
        public string SalesContractCustomerFaxNo { get; set; }
        public string SalesContractCustomerEmail { get; set; }
        public string SalesContractCustomerRepresentedBy { get; set; }
        public string SalesContractCustomerRepresentiveMobNo { get; set; }
        public string SalesContractNabinaRepresentedBy { get; set; }
        public string SalesContractPurposeProductFor { get; set; }
        public decimal? SalesContractPurposeLocationQty { get; set; }
        public string SalesContractPurposeLocation { get; set; }
        public string SalesContractQuotationCode { get; set; }
        public decimal? SalesContractQuotationAmount { get; set; }
        public DateTime? SalesContractQuotationDate { get; set; }
        public string SalesContractCustomerNameArabic { get; set; }
        public string SalesContractNabinaRepresentedByArabic { get; set; }
        public string SalesContractCustomerAddressArabic { get; set; }
        public string SalesContractCustomerRepresentedByArabic { get; set; }
        public string SalesContractPurposeProductForArabic { get; set; }
        public string SalesContractPurposeLocationArabic { get; set; }
        public bool? SalesContractIsSupply { get; set; }
        public bool? SalesContractIsInstallation { get; set; }
        public bool? SalesContractIsSiteReady { get; set; }
        public DateTime? SalesContractSiteReadinessDate { get; set; }
        public string SalesContractDescription { get; set; }
        public string SalesContractDescriptionArabic { get; set; }
        public int? SalesContractProductionDays { get; set; }
        public int? SalesContractInstallationDays { get; set; }
        public int? SalesContractStatus { get; set; }
        public DateTime? SalesContractAddedWhen { get; set; }
        public string SalesContractAddedBy { get; set; }
        public DateTime? SalesContractUpdatedWhen { get; set; }
        public string SalesContractUpdatedBy { get; set; }

        public virtual ICollection<SalesContractDoorDetails> SalesContractDoorDetails { get; set; }
        public virtual ICollection<SalesContractKitchenAccessories> SalesContractKitchenAccessories { get; set; }
        public virtual ICollection<SalesContractKitchenDetails> SalesContractKitchenDetails { get; set; }
        public virtual ICollection<SalesContractProductDetails> SalesContractProductDetails { get; set; }
        public virtual ICollection<SalesContractWardrobeDetails> SalesContractWardrobeDetails { get; set; }
    }
}
