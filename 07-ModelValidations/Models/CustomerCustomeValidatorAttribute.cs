using System.ComponentModel.DataAnnotations;

namespace _07_ModelValidations.Models
{
    public class CustomerCustomeValidator : ValidationAttribute
    {
        int minimumYear = 2000;
        public CustomerCustomeValidator(int year)
        {
            this.minimumYear = year;
        }
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            if (value != null)
            {
                DateTime date = (DateTime)value;
                if (date.Year > this.minimumYear)
                {
                    return new ValidationResult(ErrorMessage);
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