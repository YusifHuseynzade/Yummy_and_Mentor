using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Mentor_Project.DAL;
using Mentor_Project.ViewModels;



namespace Mentor_Project.Controllers
{
    public class CoursesController : Controller
    {
       
            private readonly MentorDbContext _context;

            public CoursesController(MentorDbContext context)
            {
                _context = context;
            }
        public IActionResult Index()
        {
            HomeViewModel viewModel = new HomeViewModel
            {
                Courses = _context.Courses.ToList(),
                Categories = _context.Categories.Include(x => x.Courses)
                .ThenInclude(x => x.CourseTeachers).ThenInclude(x => x.Teacher).ToList(),
            };
            return View(viewModel);
        }

    }
}
