using System;
using System.ComponentModel.DataAnnotations;

namespace MadeInEugene.Models
{
    public class Product
    {

            public int ProductId { get; set; }

            [Required(ErrorMessage = "Please enter the name of a product")]
            public string NameOfProduct { get; set; }

            [Required(ErrorMessage = "Please enter a rating.")]
            [Range(1, 5, ErrorMessage = "Please enter a rating between 1 (as the lowest) and 5 (as the highest).")]
            public int Rating { get; set; }

            [Required(ErrorMessage = "Please explain why you rated the product this way")]
            public string Review { get; set; }

            [Required(ErrorMessage = "Please enter the company.")]
            public Company Company { get; set; }


    }
}
