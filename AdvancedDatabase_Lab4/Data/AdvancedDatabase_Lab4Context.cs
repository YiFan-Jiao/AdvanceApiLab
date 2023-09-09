using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AdvancedDatabase_Lab4.Models;

namespace AdvancedDatabase_Lab4.Data
{
    public class AdvancedDatabase_Lab4Context : DbContext
    {
        public AdvancedDatabase_Lab4Context (DbContextOptions<AdvancedDatabase_Lab4Context> options)
            : base(options)
        {
        }

        public DbSet<AdvancedDatabase_Lab4.Models.Client> Client { get; set; } = default!;

        public DbSet<AdvancedDatabase_Lab4.Models.Room> Room { get; set; } = default!;
    }
}
