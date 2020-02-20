using System;
using System.Collections.Generic;

namespace Nbn.eCommenrce.ItemService.Models
{
    public partial class MailSettingMaster
    {
        public int MailSettingId { get; set; }
        public string MailSubject { get; set; }
        public string MailReceiversMailId { get; set; }
        public string MailBodyMain { get; set; }
        public string MailFooterSignatures { get; set; }
        public string MailFromEmailId { get; set; }
        public DateTime? MailSettingAddedWhen { get; set; }
        public string MailSettingAddedBy { get; set; }
    }
}
