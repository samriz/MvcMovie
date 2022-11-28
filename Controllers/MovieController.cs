using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
using Microsoft.EntityFrameworkCore;
using MvcMovie.Models;

namespace MvcMovie.Controllers;

public class MovieController : Controller
{
    private readonly MovieContext movieContext;

    public MovieController(MovieContext movieContext)
    {
        this.movieContext = movieContext;
    }

    // GET: /HelloWorld/
    public IActionResult Index()
    {
        return View();
    }
    
    public int PostMovie(Movie movie)
    {
        movieContext.Movies.Add(movie);
        return movieContext.SaveChanges();
    }

    public List<Movie> GetMovies()
    {
        return movieContext.Movies.ToList();
    }
}