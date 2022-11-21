using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Yummy_Project.DAL;
using Yummy_Project.Models;
using Yummy_Project.ViewModels;

namespace Yummy_Project.Controllers
{
    public class HomeController : Controller
    {
        private readonly YummyDbContext _context;


        public HomeController(YummyDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
           
                HomeViewModel viewModel = new HomeViewModel
                {
                    Testimonials = _context.Testimonials.ToList(),
                    Positions = _context.Positions.Include(x => x.Testimonials).ToList(),
                    Meals = _context.Meals.ToList(),
                    Categories = _context.Categories.Include(x => x.Meals)
                    .ThenInclude(x => x.MealIngredients).ThenInclude(x => x.Ingredient).ToList(),
                };
                return View(viewModel);
            }
            
        }

    
    }

