using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Yummy_Project.Models
{
    public class Position
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(30)]
        public string Name { get; set; }
        public List<Testimonial> Testimonials { get; set; }
      
    }
}
