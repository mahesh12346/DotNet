using Linq.Data;
using Linq.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Linq.Controllers
{
    public class HomeController : Controller
    {
        //private readonly ILogger<HomeController> _logger;

        private readonly ApplicationDbContext _context;

        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult DisplayMaleData()
        {
            var data = _context.Employees.Where(e => e.gender == "M").ToList();
            return View(data);
        }

        public IActionResult DisplayFemaleData()
        {
            var data = _context.Employees.Where(e => e.gender == "F").ToList();
            return View(data);
        }

        public IActionResult DisplayEmp()
        {

            var data = _context.Employees.ToList();


            return View(data);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
