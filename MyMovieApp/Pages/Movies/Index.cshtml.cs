using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MyMovieApp.Data;
using MyMovieApp.Models;

namespace MyMovieApp
{
    public class IndexModel : PageModel
    {
        private readonly MyMovieApp.Data.MyMovieAppContext _context;

        public IndexModel(MyMovieApp.Data.MyMovieAppContext context)
        {
            _context = context;
        }

        public IList<Movies> Movies{ get; set; }

        public async Task OnGetAsync()
        {
            List<Models.Movies> lists = await _context.Movies.ToListAsync();
            Movies = (IList<Movies>)lists;
        }
    }
}
