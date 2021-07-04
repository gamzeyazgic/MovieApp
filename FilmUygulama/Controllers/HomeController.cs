using FilmUygulama.Data;
using FilmUygulama.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace FilmUygulama.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index(int? id)
        {
            var movies = MovieRepository.Movies;
            if (id != null)
            {
                movies = movies.Where(i => i.CategoryId == id).ToList();
            }
            return View(movies);
        }
        public IActionResult Details(int id)
        {
            //MovieCategoryModel model = new MovieCategoryModel();
            //model.Categories = CategoryRepository.Categories;
            //model.Movie = MovieRepository.GetById(id);

            return View(MovieRepository.GetById(id));
        }

        public IActionResult Contact()
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
