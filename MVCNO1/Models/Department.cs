using System.ComponentModel.DataAnnotations;

namespace MVCNO1.Models
{
    public class Department
    {

        public int Id { get; set; }
        [Display(Name="Dept Name")]
        [Required]
        [UniqueName]
        [MaxLength(25,ErrorMessage ="Name must less than 25 letter")]
        [MinLength(3, ErrorMessage = "Name must greater than 2 letter")]
        public string Name { get; set; }
        [Required]
        [MaxLength (25, ErrorMessage = "Manager Name must less than 25 letter")]
        [MinLength(3, ErrorMessage = "Manager Name must greater than 2 letter")]
        public string? ManagerName { get; set; }
        [Required]
        [RegularExpression(@"Alex|Cairo",ErrorMessage ="Address must be Alex Or Cairo")]
        public string Address { get; set; }
        [Required]
        [Range(20,50,ErrorMessage="Age must be from 20 to 50")]
        public int Age { get; set; }    
    }
}