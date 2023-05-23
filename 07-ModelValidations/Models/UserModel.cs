using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.ComponentModel.DataAnnotations;

namespace _07_ModelValidations.Models
{
    public class UserModel : IValidatableObject
    {
        // Compare // Min lenght max length // Regex // phone // emailAddress // compare 
        // ValidateNever

        [Required(ErrorMessage = "{0} Field is Required Field its not empty in any case")]
        [Display(Name = "Customer Id")]



        public int? Id { get; set; }

        public string? Name { get; set; }
        public List<string?> Tags { get; set; } = new List<string?>();
        public string? email { get; set; }
        public int? age { get; set; }
        [CustomerCustomeValidator(2005, ErrorMessage = "The Year is must be greater then 2002")]
        public DateTime dob { get; set; }
        [BindNever]
        public DateTime? From { get; set; }
        // IValidationObject is used to write validation in the same class 

        public DateTime? Todate { get; set; }
        public int? presentAge { get; set; }

        public override string ToString()
        {
            return $"Id: {Id} name : {Name} email: {email} Age : {age} date=of-birth :{dob} ";
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (presentAge.HasValue == false)
            {
                yield return new ValidationResult("The Age is mendatory field "
                     , new[] { nameof(presentAge) });
            }
        }
    }
}
