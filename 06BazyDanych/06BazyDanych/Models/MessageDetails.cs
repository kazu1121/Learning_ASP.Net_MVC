using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.AccessControl;
using System.Web;

namespace _06BazyDanych.Models
{
    public class MessageDetails
    {
        [Key]
        public int MessageDetailsId { get; set; }

        [Required(ErrorMessage = "Adres email jest wymagany!")]
        [DataType(DataType.EmailAddress, ErrorMessage = "Wprowadzono niepoprawny format adresu email!")]
        public string emailAuthor { get; set; }

        public string subject { get; set; }

        [Required(ErrorMessage = "Treść wiadomości jest wymagana!")]
        public string messageDetails { get; set; }
    }
}