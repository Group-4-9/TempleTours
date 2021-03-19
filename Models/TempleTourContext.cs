using System;
using Microsoft.EntityFrameworkCore;

namespace TempleTours.Models
{
    public class TempleTourContext : DbContext
    {
        public TempleTourContext(DbContextOptions<TempleTourContext> options) : base(options)
        {
        }

        public DbSet<Group> Groups { get; set; }


    }
}
