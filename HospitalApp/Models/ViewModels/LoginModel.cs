using System.ComponentModel.DataAnnotations;

namespace HospitalApp.Models.ViewModels
{
    public class LoginModel
    {
        [Required]
         public string Login { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
