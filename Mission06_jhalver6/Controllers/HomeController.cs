using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
        private MovieCollectionContext mcContext { get; set; }

        public HomeController(MovieCollectionContext someName)
        {
            mcContext = someName;
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

            ViewBag.Categories = mcContext.Categories.ToList();

            return View();
        }

        [HttpPost]
        public IActionResult NewMovie(AddMovie am)
        {
            if (ModelState.IsValid)
            {
                mcContext.Add(am);
                mcContext.SaveChanges();
                return View("Confirmation", am);
            }
            else
            {
                ViewBag.Categories = mcContext.Categories.ToList();
                return View(am);
            }
        }
        public IActionResult Podcast()
        {
            return View();
        }

        public IActionResult CollectionList()
        {
            var collections = mcContext.Movie
                .Include(x => x.Category)
                .OrderBy(x => x.Title)
                .ToList();

            return View(collections);
        }
        [HttpGet]
        public IActionResult Edit(int movieid)
        {
            ViewBag.Categories = mcContext.Categories.ToList();

            var movie = mcContext.Movie.Single(x => x.MovieId == movieid);

            return View("NewMovie", movie);
        }

        [HttpPost]

        public IActionResult Edit (AddMovie movie)
        {
            mcContext.Update(movie);
            mcContext.SaveChanges();
            return RedirectToAction("CollectionList");
        }
        [HttpGet]
        public IActionResult Delete(int movieid)
        {
            var movie = mcContext.Movie.Single(x => x.MovieId == movieid);

            return View(movie);
        }
        [HttpPost]

        public IActionResult Delete (AddMovie am)
        {
            mcContext.Movie.Remove(am);
            mcContext.SaveChanges();

            return RedirectToAction("CollectionList");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        
        
    }
}
