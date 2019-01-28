using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace ProjectName.ViewModels
{
    public class RegisterViewModel
    {
        
        [Required(ErrorMessage = "This Field Is Required")]
        [Remote("UserExists", "Account", ErrorMessage = "Username Already In Use")]
        public string Username { get; set; }

        [Required(ErrorMessage = "This Field Is Required")]
        public string Password { get; set; }

        [Required(ErrorMessage = "You Need To Confirm Your Password")]
        [System.ComponentModel.DataAnnotations.Compare("Password", ErrorMessage = "Passwords do not match")]
        public string ConfirmPassword { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }
    }
}