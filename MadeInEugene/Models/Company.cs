using System;
using System.ComponentModel.DataAnnotations;

namespace MadeInEugene.Models
{
    public class Company
    {
        public int CompanyId { get; set; }

        [Required(ErrorMessage = "Please enter the name of a company")]
        public string NameOfCompany { get; set; }

        [Required(ErrorMessage = "Please enter its contact info (email or phone)")]
        public string contactInfo { get; set; }

    }
}
