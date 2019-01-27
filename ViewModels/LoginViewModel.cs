using System.ComponentModel.DataAnnotations;

namespace Vidly.ViewModels
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "This Field Is Required")]
        public string Username { get; set; }

        [Required(ErrorMessage = "This Field Is Required")]
        public string Password { get; set; }
    }
}