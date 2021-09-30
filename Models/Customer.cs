using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TermProject_S1.Models
{
    public class Customer
    {
        public int Id { get; set; }
        [Required]
        [StringLength(30, ErrorMessage = "Please enter full name, 30 characters or less.")]
        public string Name { get; set; }
        [StringLength(50, ErrorMessage = "Please enter full address, 50 characters or less.")]
        public string Address { get; set; }
        [StringLength(30, ErrorMessage = "Please enter city.")]
        public string City { get; set; }
        [StringLength(2, ErrorMessage = "Please state abbreviation.")]
        public string State { get; set; }
        [StringLength(10, ErrorMessage = "Please enter zip code, 10 digits or less.")]
        public string ZipCode { get; set; }
        public string EmailAddress { get; set; }
        public string PhoneNumber { get; set; }
        public double Discount { get; set; }
    }
}
