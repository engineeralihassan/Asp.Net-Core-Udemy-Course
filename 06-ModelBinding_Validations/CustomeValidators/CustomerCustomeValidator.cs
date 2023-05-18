using System.ComponentModel.DataAnnotations;

namespace _06_ModelBinding_Validations.CustomeValidators
{
    public class CustomerCustomeValidator : ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            if (value != null)
            {
                DateTime date = (DateTime)value;
                if (date.Year > 2002)
                {
                    return new ValidationResult("The Year is must be above 2002");
                }
                else
                {
                    return ValidationResult.Success;
                }

            }
            return null;
        }
    }
}
