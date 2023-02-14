using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Mission06_jhalver6.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Mission06_jhalver6.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private MovieCollectionContext _blahContext { get; set; }

        public HomeController(ILogger<HomeController> logger, MovieCollectionContext someName)
        {
            _logger = logger;
            _blahContext = someName;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [HttpGet]
        public IActionResult NewMovie()
        {
            return View();
        }

        [HttpPost]
        public IActionResult NewMovie(AddMovie am)
        {
            if (ModelState.IsValid)
            {
                _blahContext.Add(am);
                _blahContext.SaveChanges();
                return View("Confirmation", am);
            }
            else
            {
                return View();
            }
        }
        public IActionResult Podcast()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        
        
    }
}
