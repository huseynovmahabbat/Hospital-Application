using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HospitalApp.Models
{
    public class Patient:Entity
    {
        [Required]
        [StringLength(30)]
        public string Name { get; set; }
        [Required]
        [StringLength(30)]
        public string Surname { get; set; }
        [Required]
        [StringLength(30)]
        [Index(IsClustered =false,IsUnique =true)]
        public string Email { get; set; }
        [Required]
        [StringLength(30)]
        public string Password { get; set; }
       
    }
}
