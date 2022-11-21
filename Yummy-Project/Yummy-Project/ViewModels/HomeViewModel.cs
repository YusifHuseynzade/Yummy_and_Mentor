using System.Collections.Generic;
using Yummy_Project.Models;

namespace Yummy_Project.ViewModels
{
    public class HomeViewModel
    {
        public List<Testimonial> Testimonials { get; set; }
        public List<Meal> Meals { get; set; }
        public List<Category> Categories { get; set; }
        public List<Position> Positions { get; set; }
    }
}
