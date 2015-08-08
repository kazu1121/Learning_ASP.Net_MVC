using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KontrolerZadanie.Models
{
    public class Message
    {
        public string email { get; set; }
        public string subject { get; set; }
        public string messageDetails { get; set; }
    }
}