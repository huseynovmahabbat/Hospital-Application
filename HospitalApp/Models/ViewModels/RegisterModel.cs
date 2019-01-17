using System.ComponentModel.DataAnnotations;

namespace HospitalApp.Models.ViewModels
{
    public class RegisterModel
    {
        [Required]
        [StringLength(maximumLength:30,MinimumLength =3)]
        public string Name { get; set; }
        [Required]
        [StringLength(maximumLength: 30, MinimumLength = 3)]
        public string Surname { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [StringLength(maximumLength: 30, MinimumLength = 3)]
        public string Password { get; set; }

        [Compare("Password")]
        public string ConfirmPassword { get; set; }
        

        public static implicit operator Patient(RegisterModel model)
        {
            return new Patient
            {
                Email = model.Email,
                Name = model.Name,
                Surname = model.Surname,
                Password = model.Password
            };
        }
    }
}
