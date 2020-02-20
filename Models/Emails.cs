using System;
using System.Collections.Generic;

namespace Nbn.eCommenrce.ItemService.Models
{
    public partial class Emails
    {
        public int EmailId { get; set; }
        public string EmailTo { get; set; }
        public string EmailCc { get; set; }
        public string EmailSubject { get; set; }
        public string EmailFrom { get; set; }
        public string EmailBody { get; set; }
        public string EmailAttachment1 { get; set; }
        public string EmailAttachment2 { get; set; }
        public string EmailAttachment3 { get; set; }
        public string SystemAttachment1 { get; set; }
        public string SystemAttachment2 { get; set; }
        public string SystemAttachment3 { get; set; }
        public DateTime? EmailSentDate { get; set; }
        public string EmailSentBy { get; set; }
        public int? UserId { get; set; }
        public int? EmailStatus { get; set; }
        public string EmailRemarks { get; set; }
        public string EmailAddedBy { get; set; }
        public DateTime? EmailAddedwhen { get; set; }
        public string EmailUpdatedBy { get; set; }
        public DateTime? EmailUpdatedWhen { get; set; }
    }
}
