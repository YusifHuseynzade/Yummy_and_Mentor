using Mentor_Project.Models;
using System.Collections.Generic;

namespace Mentor_Project.ViewModels
{
    public class HomeViewModel
    {
        public List<Course> Courses { get; set; }
        public List<Category> Categories { get; set; }
    }
}
