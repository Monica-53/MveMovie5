using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MvcMovie.Models;

namespace MveMovie5.Data
{
    public class MveMovie5Context : DbContext
    {
        public MveMovie5Context (DbContextOptions<MveMovie5Context> options)
            : base(options)
        {
        }

        public DbSet<MvcMovie.Models.Movie> Movie { get; set; }
    }
}
