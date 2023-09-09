using System.ComponentModel.DataAnnotations;

namespace lab4.Models
{
    public class Client
    {
        [Key]
        public int Id { get; set; }

        [MinLength(3)]
        [MaxLength(25)]
        [Display(Name = "First Name")]
        public string? FirstName { get; set; }

        [Required]
        [MinLength(3)]
        [MaxLength(25)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }


        [Phone]
        [RegularExpression(@"^(\+\d{1, 2}\s)?\(?\d{3}\)?[\s.-]?\d{3}[\s.-] ?\d{4}$", ErrorMessage = "Phone number must match format of [***-***-****]")]
        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; }
    }
}
