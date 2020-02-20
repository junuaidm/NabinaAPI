using System;
using System.Collections.Generic;

namespace Nbn.eCommenrce.ItemService.Models
{
    public partial class EmailLog
    {
        public int EmailLogFileId { get; set; }
        public int? ItemId { get; set; }
        public int? EmailTypeId { get; set; }
        public string LogType { get; set; }
        public DateTime? LogDate { get; set; }
        public int? DocumentId { get; set; }
        public string EmailLogEmailSubject { get; set; }
        public string EmailLogEmailBody { get; set; }
        public string EmailLogEmailFromId { get; set; }
        public string EmailLogToEmailRecipients { get; set; }
        public string EmailLogCcrecipients { get; set; }
        public bool? EmailLogEmailStatus { get; set; }
        public string EmailLogEmailAddedBy { get; set; }
    }
}
