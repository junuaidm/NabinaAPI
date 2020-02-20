using System;
using System.Collections.Generic;

namespace Nbn.eCommenrce.ItemService.Models
{
    public partial class SpallowedDiscounts
    {
        public int AllowedDiscountId { get; set; }
        public decimal? AllowedDiscount { get; set; }
        public int? EmpId { get; set; }
        public int? ItemId { get; set; }
        public byte? AllowedDiscountStatus { get; set; }
        public string AllowedDiscountAddedBy { get; set; }
        public DateTime? AllowedDiscountAddedWhen { get; set; }
        public string AllowedDiscountUpdatedBy { get; set; }
        public DateTime? AllowedDiscountUpdatedWhen { get; set; }
    }
}
