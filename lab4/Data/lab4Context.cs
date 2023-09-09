using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using lab4.Models;

namespace lab4.Data
{
    public class lab4Context : DbContext
    {
        public lab4Context (DbContextOptions<lab4Context> options)
            : base(options)
        {
        }

        public DbSet<lab4.Models.Client> Client { get; set; } = default!;

        public DbSet<lab4.Models.Room>? Room { get; set; } = default!;
    }
}
