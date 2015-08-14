using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace _07Infrastruktura.Models
{
    public class MessageDetails
    {
        public int MessageDetailsId { get; set; }

        [Required(ErrorMessage = "Pole adresata jest wymagane!")]
        [DataType(DataType.EmailAddress)]
        public string authorEmail { get; set; }

        public string subject { get; set; }

        [Required(ErrorMessage = "Pole wiadomości jest wymagane!")]
        [DataType(DataType.MultilineText)]
        public string messageDetails { get; set; }
    }
}