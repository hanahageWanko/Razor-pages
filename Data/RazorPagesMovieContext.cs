using Miceosoft.EntityFrameworkCore;

namespace RazorPagesMovie.Data
{
  public class RazorPagesMovieContext : DbContext
  {
    public RazorPagesMovieContext (
      DbContextOptions<RazorPagesMovieContext> options)
      : base(opitions)
    {
    }

    public DbSet<RazorPagesMovie.Models.Movie> Movie {get; set;}
  }
}