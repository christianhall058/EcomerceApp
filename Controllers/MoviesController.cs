using EcomerceApp.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EcomerceApp.Controllers
{
    public class MoviesController : Controller
    {
        private readonly AppDbContext _context;

        public MoviesController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var data = _context.Movies.Include(n => n.Cinema).OrderBy(n => n.Name).ToList();
            return View(data);
        }
    }
}
