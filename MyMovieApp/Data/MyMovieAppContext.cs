using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MyMovieApp.Models;

namespace MyMovieApp.Data
{
    public class MyMovieAppContext : DbContext
    {
        public MyMovieAppContext (DbContextOptions<MyMovieAppContext> options)
            : base(options)
        {
        }

        public DbSet<MyMovieApp.Models.Movies> Movie { get; set; }
    }
}
