using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Model;

namespace Presentation.Utilities
{
    public class DataAnnotationValidation
    {
        public void CheckValidation(SanPham model)
        {
            string errorMessage = "";
            // list store invalidate
            List<ValidationResult> results = new List<ValidationResult>();
            
            ValidationContext context = new ValidationContext(model);
            bool isValidate = Validator.TryValidateObject(model, context, results, true);
            bool isValidateChild = true;
            if (model.laptop != null)
            {
                context = new ValidationContext(model.laptop);
                isValidateChild = Validator.TryValidateObject(model.laptop, context, results, true);
            }
            else if (model.banPhim != null)
            {
                context = new ValidationContext(model.banPhim);
                isValidateChild = Validator.TryValidateObject(model.banPhim, context, results, true);
            }
            else
            {
                context = new ValidationContext(model.chuot);
                isValidateChild = Validator.TryValidateObject(model.chuot, context, results, true);
            }

            if (isValidate==false)
            {
                foreach (var item in results)
                {
                    errorMessage += "- " + item.ErrorMessage + "\n";
                }
            }
            if (isValidateChild == false)
            {
                foreach (var item in results)
                {
                    errorMessage += "- " + item.ErrorMessage + "\n";
                }
            }
            throw new Exception(errorMessage);

        }
    }
}
