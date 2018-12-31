using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalApp.Models
{
   public class PatientNote:Entity
    {
        public Doctor Doctor { get; set; }
        [Required]
        public int DoctorId { get; set; }
        public Patient Patient { get; set; }
        [Required]
        public int PatientId { get; set; }
        [Required]
        public DateTime RecieptTime { get; set; }
        public string Description { get; set; }

    }
}
