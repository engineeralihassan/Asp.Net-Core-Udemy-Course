using System.ComponentModel.DataAnnotations;

namespace _07_ModelValidations.Models
{
    public class UserModel
    {
        // Compare // Min lenght max length // Regex // phone // emailAddress // compare 
        // ValidateNever

        [Required(ErrorMessage = "{0} Field is Required Field its not empty in any case")]
        [Display(Name = "Customer Id")]



        public int? Id { get; set; }

        public string? Name { get; set; }
        public string? email { get; set; }
        public int? age { get; set; }
        [CustomerCustomeValidator(2005, ErrorMessage = "The Year is must be greater then 2002")]
        public DateTime dob { get; set; }
        public override string ToString()
        {
            return $"Id: {Id} name : {Name} email: {email} Age : {age} date=of-birth :{dob} ";
        }
    }
}
