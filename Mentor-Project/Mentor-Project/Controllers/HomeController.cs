using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Mentor_Project.DAL;

namespace Mentor_Project.Controllers
{
    public class HomeController : Controller
    {

        private readonly MentorDbContext _context;

            public HomeController(MentorDbContext context)
            {
                _context = context;
            }

            public IActionResult Index()
            {
                return View();
            }
        
    }
}
