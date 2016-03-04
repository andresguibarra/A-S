using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCPagina.Models
{
    public class MailModel
    {
        public string From { get; set; }
        public string Name { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }

        public string PhoneNumber { get; set; }
    }
}