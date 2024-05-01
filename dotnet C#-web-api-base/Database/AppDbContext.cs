using Microsoft.EntityFrameworkCore;

namespace dotnet_C__web_api_base.Database
{
    public class AppDbContext : DbContext
    {
       // public DbSet<-TYPE-> -variable name- { get; set; }
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }
    }
}
