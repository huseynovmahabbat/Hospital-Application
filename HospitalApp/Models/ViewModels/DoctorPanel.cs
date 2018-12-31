using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalApp.Models.ViewModels
{
   public class DoctorPanel
    {
       public string Name { get; set; }
       public string Surname { get; set; }
       public DateTime receiptTime { get; set; }
       public string Description { get; set; }
    }
}
