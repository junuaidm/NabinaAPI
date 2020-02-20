using System;
using System.Collections.Generic;

namespace Nbn.eCommenrce.ItemService.Models
{
    public partial class SalesQuotationRawMaterial
    {
        public int Sqrmid { get; set; }
        public int? SqdetailId { get; set; }
        public int? Bomrmid { get; set; }
        public int? SqrawMaterialId { get; set; }
        public int? BomrmunitId { get; set; }
        public decimal? ItemCost { get; set; }
        public decimal? SqrawMaterialQty { get; set; }
        public string SqrmaddedBy { get; set; }
        public DateTime? SqrmaddedWhen { get; set; }
        public string SqrmupdatedBy { get; set; }
        public DateTime? SqrmupdatedWhen { get; set; }
    }
}
