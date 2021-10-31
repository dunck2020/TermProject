using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TermProject_S1.Models
{
    public class CustomerGrade
    {
        [Key]
        public int CustomerGradeID { get; set; }
        public string CustomerSalesLevel { get; set; }

    }
}
