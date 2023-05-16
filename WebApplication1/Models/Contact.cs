using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class Contact
    {
        [Display(Name = "Enter your name:")]
        [Required(ErrorMessage = "You need to fill this field up")]
        public string Name { get; set; }

        [Display(Name = "Enter your last name:")]
        [Required(ErrorMessage = "You need to fill this field up")]
        public string LastName { get; set; }

        [Display(Name = "Enter your age:")]
        [Required(ErrorMessage = "You need to fill this field up")]
        public int Age { get; set; }

        [Display(Name = "Enter your email:")]
        [Required(ErrorMessage = "You need to fill this field up")]
        public string Email { get; set; }

        [Display(Name = "Add a comment:")]
        [StringLength(25, ErrorMessage = "Comment must contain less than 30 symbols")]
        [Required(ErrorMessage = "You need to fill this field up")]
        public string Message { get; set; }

    }
}
