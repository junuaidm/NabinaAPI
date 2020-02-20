using System;
using System.Collections.Generic;

namespace Nbn.eCommenrce.ItemService.Models
{
    public partial class Erpconfig
    {
        public int ConfigId { get; set; }
        public string VariableName { get; set; }
        public string VariableType { get; set; }
        public string VariableValue { get; set; }
    }
}
