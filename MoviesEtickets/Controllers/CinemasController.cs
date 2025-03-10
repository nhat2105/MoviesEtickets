﻿using Microsoft.AspNetCore.Mvc;
using MoviesEtickets.Data;
using Microsoft.EntityFrameworkCore;

namespace MoviesEtickets.Controllers
{
    public class CinemasController : Controller
    {
        private readonly AppDbContext _context;

        public CinemasController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var data = await _context.Cinemas.ToListAsync();
            return View(data);
        }
    }
}
