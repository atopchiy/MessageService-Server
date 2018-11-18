using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MessageService.Models
{
    public class MessageModel
    {
        public List<string> Recipients { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
    }
}