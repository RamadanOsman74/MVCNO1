using System.ComponentModel.DataAnnotations;

namespace MVCNO1.Models
{
    public class UniqueNameAttribute: ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            if (value == null)
            {
                return null;
            }
            string newname = value.ToString();
            ITIDbContext iTIDbContext = new ITIDbContext();
            Student std = iTIDbContext.Students.FirstOrDefault(s => s.Name == newname);
            if (std != null)
            {
                return  new ValidationResult( ErrorMessage = "Name Must be Unique");
            }
            return ValidationResult.Success;

        }
    }
}
