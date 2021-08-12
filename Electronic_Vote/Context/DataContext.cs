using Electronic_Vote.Models;
using Microsoft.EntityFrameworkCore;

namespace Electronic_Vote.Context
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Candidate> Candidates { get; set; }
    }
}
