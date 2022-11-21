using System.ComponentModel.DataAnnotations;

namespace Mentor_Project.Models
{
    public class Teacher
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(25)]
        public string Name { get; set; }
    }
}
