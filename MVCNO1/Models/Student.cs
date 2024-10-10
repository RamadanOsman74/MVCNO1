using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVCNO1.Models
{
    public class Student
    {
        public int Id { get; set; }
        [Display(Name= "student Name")]
        [Required]
        [MaxLength(25)]
        [MinLength(2)]

        public string Name { get; set; }
        [Required]
        [Range(20, 50)]
       
        public int Age { get; set; }
        [Required]
        [RegularExpression(@"\w+\.(png|jpg)")]
        public string Image { get; set; }
        [ForeignKey("department")]
        public int DeptId { get; set; }
        [RegularExpression(@"Alex|Cairo")]
        public string Address { get; set; }
        public Department department { get; set; }
    }
}
