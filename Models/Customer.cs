using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TermProject_S1.Models
{
    public class Customer
    {
        [Key]
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
        [Display(Name = "Zip Code")]
        public string ZipCode { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime CustomerSince { get; set; }

        [RegularExpression(@"[a-z0-9._%+-]+@[a-z0-9.-]+\.[a-z]{2,4}", ErrorMessage = "Incorrect Email Format")]
        [Display(Name = "Email Address")]
        public string EmailAddress { get; set; }

        [Display(Name = "Phone Number")]
        [RegularExpression(@"^(\+\s?)?((?<!\+.*)\(\+?\d+([\s\-\.]?\d+)?\)|\d+)([\s\-\.]?(\(\d+([\s\-\.]?\d+)?\)|\d+))*(\s?(x|ext\.?)\s?\d+)?$", ErrorMessage = "The PhoneNumber field is not a valid phone number")]
        public string PhoneNumber { get; set; }

        public double Discount { get; set; }

        [Column("Customer Sales Level")]
        [ForeignKey("CustomerGradeID")]
        public int CustomerGradeID { get; set; }

        [Display(Name = "Customer Grade")]
        public CustomerGrade CustomerGrade { get; set; }
    }
}
