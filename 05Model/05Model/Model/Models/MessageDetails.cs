using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Model.Models
{
    public class MessageDetails
    {
        [Required(ErrorMessage = "Podaj swój email")]
        [DataType(DataType.EmailAddress)]
        public string emailAuthor { get; set; }


        public string subject { get; set; }

        [Required(ErrorMessage = "Podaj treść wiadomości")]
        [DataType(DataType.MultilineText)]
        public string messageDetails { get; set; }      
    }
}