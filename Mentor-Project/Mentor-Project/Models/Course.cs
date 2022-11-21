using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Mentor_Project.Models
{
    public class Course
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(30)]
        public string Name { get; set; }
        public int? CategoryId { get; set; }
        public string Desc { get; set; }
        [MaxLength(100)]
        public string Image { get; set; }

        public Category Category { get; set; }
        public List<CourseTeacher> CourseTeachers { get; set; }
    }
}
