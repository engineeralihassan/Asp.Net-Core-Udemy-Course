using System.ComponentModel.DataAnnotations;

namespace _07_ModelValidations.Models
{
    public class UserModel
    {
        [Required(ErrorMessage = "TheId Field is Required Field its not empty in any case")]
        public int? Id { get; set; }
        public string? Name { get; set; }
        public string? email { get; set; }
        public int? age { get; set; }
        public override string ToString()
        {
            return $"Id: {Id} name : {Name} email: {email} Age : {age} ";
        }
    }
}
