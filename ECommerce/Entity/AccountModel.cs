using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class AccountModel:BaseModel
    {
        [Required(ErrorMessage = "Please fill this field")]
        [DisplayName("Full Name")]
        public string FullName { get; set; }
        [Required(ErrorMessage = "Please fill this field")]
        [DisplayName("Phone")]
        [DataType(DataType.PhoneNumber)]
        [Phone]
        public string PhoneNumber { get; set; }
        [DisplayName("Date Of Birth")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? DateOfBirth { get; set; }
        [Required(ErrorMessage = "Please fill this field")]
        [DisplayName("Email")]
        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        public string Email { get; set; }
        [Required(ErrorMessage = "Please fill this field")]
        [DisplayName("Password")]
        [DataType(DataType.Password)]
        [PasswordPropertyText]
        [MinLength(6)]
        public string Password { get; set; }
        [NotMapped]
        [Required(ErrorMessage = "Please fill this field")]
        [DisplayName("Confirm Password")]
        [DataType(DataType.Password)]
        [Compare("Password")]
        public string ConfirmPassword { get; set; }
        [NotMapped]
        [DisplayName("Remember Me")]
        public bool RememberMe { get; set; }

    }
}
