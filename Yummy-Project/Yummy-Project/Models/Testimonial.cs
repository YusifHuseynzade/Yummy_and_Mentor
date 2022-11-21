using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Yummy_Project.Models
{
    public class Testimonial
    {
        public int Id { get; set; }
        public int? PositionId { get; set; }

        [Required]
        [MaxLength(300)]
        public string Desc { get; set; }
        [Required]
        [MaxLength(25)]
        public string FullName { get; set; }
        [Required]
        [MaxLength(25)]
        public string Image { get; set; }
        [Required]
        public byte StarCount { get; set; }

        public Position Position { get; set; }
    }
}
