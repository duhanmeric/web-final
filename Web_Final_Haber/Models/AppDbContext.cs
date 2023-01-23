using Microsoft.EntityFrameworkCore;

namespace Web_Final_Haber.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
    : base(options) { }
        public DbSet<NewsArticle> Articles { get; set; }
    }
}
