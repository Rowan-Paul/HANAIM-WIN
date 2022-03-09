using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;

namespace bp2_server.Models
{
    public class MovieContext : DbContext
    {
        public MovieContext(DbContextOptions<MovieContext> options)
            : base(options)
        {
        }

        public DbSet<Movie> Movies { get; set; } = null!;
    }
}