using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MvcMovie.Models
{
    public class MvcReviewsContext : DbContext
    {
        public MvcReviewsContext (DbContextOptions<MvcReviewsContext> options)
            : base(options)
        {
        }

        public DbSet<MvcMovie.Models.Reviews> Reviews { get; set; }
    }
}
