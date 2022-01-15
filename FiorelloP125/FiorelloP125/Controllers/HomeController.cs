using FiorelloP125.DAL;
using FiorelloP125.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace FiorelloP125.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;
        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {

            HomeVM model = new HomeVM()
            {
                Categories = _context.Categories.ToList(),
                Flowers=_context.Flowers.Include(f=>f.FlowerImages).Include(f=>f.Compaign).Include(f=>f.FlowerCategories).ThenInclude(fc=>fc.Category).ToList(),
            };
            return View(model);
        }
    
    }
}
