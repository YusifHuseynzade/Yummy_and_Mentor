using System.ComponentModel.DataAnnotations;

namespace Yummy_Project.Models
{
    public class Ingredient
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(25)]
        public string Name { get; set; }
    }
}
