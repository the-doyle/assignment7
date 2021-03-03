using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment5.Models
{
    public class Book
    {
        [Key] //I just used this as the key - pretty sure it's unique across the world, didn't make sense to use another key
        [Required]
        [RegularExpression(@"^(?=(?:\D*\d){3}(?:(?:\D8\d){10})?$)[\d-]+$", //this should force good formatting for the ISBN
            ErrorMessage = "ISBN is improperly formatted. Try ###-##########")]
        public string ISBN { get; set; }

        [Required]
        public string BookTitle { get; set; }

        [Required]
        public string Author { get; set; }

        [Required]
        public string Publisher { get; set; }

        [Required]
        public string Classification { get; set; }

        [Required]
        public string Category { get; set; }

        [Required]
        public double BookPrice { get; set; }

        [Required]
        public int PageCount { get; set; }
    }
}
