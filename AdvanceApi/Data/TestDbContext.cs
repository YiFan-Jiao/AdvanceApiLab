using AdvanceApi.Models;
using Microsoft.EntityFrameworkCore;

namespace AdvanceApi.Data
{
    public class TestDbContext : DbContext
    {
        public TestDbContext(DbContextOptions options) : base(options) { }

        public DbSet<Customer> Customers { get; set; } = null!;
        public DbSet<Address> Addresses { get; set; } = null!;
    }
}
