using System;
using System.Collections.Generic;

namespace Nbn.eCommenrce.ItemService.Models
{
    public partial class SalesGroupDiscount
    {
        public int GroupDisId { get; set; }
        public int? SalesGroupId { get; set; }
        public int? GroupDisDefined { get; set; }
        public decimal? GroupDisAmount { get; set; }
        public int? ItemId { get; set; }
        public int? SupplierId { get; set; }
        public int? ItemTypeId { get; set; }
        public int? GroupDisValidity { get; set; }
        public DateTime? GroupDisValidFrom { get; set; }
        public DateTime? GroupDisValidTo { get; set; }
        public bool? GroupDisIsActive { get; set; }
        public string GroupDisNotes { get; set; }
        public string GroupDisAddedBy { get; set; }
        public DateTime? GroupDisAddedWhen { get; set; }
        public string GroupDisUpdatedBy { get; set; }
        public DateTime? GroupDisUpdatedWhen { get; set; }

        public virtual SalesGroupDiscountDefinedFor GroupDisDefinedNavigation { get; set; }
        public virtual ItemType ItemType { get; set; }
        public virtual SalesGroup SalesGroup { get; set; }
        public virtual Suppliers Supplier { get; set; }
    }
}
