using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace lab6.Models
{
    [Table("Students")]
    public class Student
    {
        [Key]
        public int StudentId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        [Phone]
        public string ContactNumber { get; set; } // Change int to string for phone compatibility

        [Required]
        public string FatherName { get; set; }

        [Required]
        public int Year { get; set; }
    }
}
