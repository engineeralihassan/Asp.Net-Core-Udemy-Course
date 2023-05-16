namespace _06_ModelBinding_Validations.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public override string ToString()
        {
            return $"The books is : {Name} and book Id is : {Id}";
        }
    }
}
