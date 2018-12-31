using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalApp.Helpers
{
   public static class CustomValidator
    {
        public static bool TryValidateObject(object obj,Label label)
        {
            List<ValidationResult> results = new List<ValidationResult>();
            ValidationContext context = new ValidationContext(obj);

           bool validate =  Validator.TryValidateObject(obj, context, results, true);
            if (!validate)
            {
                label.Text = "";
                foreach (ValidationResult item in results)
                {
                    label.Text += item.ErrorMessage + "\n";

                }
            }
            return validate;
        }
    }
}
