using Microsoft.AspNetCore.Mvc;
using MoviesEtickets.Data;
using Microsoft.EntityFrameworkCore;

namespace MoviesEtickets.Controllers
{
    public class MoviesController : Controller
    {
        private readonly AppDbContext _context;

        public MoviesController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var data = await _context.Movies.ToListAsync();
            return View();
        }
    }
}
