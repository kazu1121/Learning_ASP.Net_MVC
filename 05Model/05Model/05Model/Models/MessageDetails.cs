using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace _05Model.Models
{
    public class MessageDetails
    {
        [DisplayName("Twój email: ")]
        [Required]
        public string authorEmail { get; set; }


        public string subject { get; set; }

        [DisplayName("Treść wiadomości: ")]
        [Required]
        public string messageDetails { get; set; }
    }
}