using Microsoft.EntityFrameworkCore;

namespace PortfolioAPI.DataAccess.Entity.APIContext
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-TL59DVJ\\SQLEXPRESS;database=PortfolioAPIDB;integrated security=true");
        }

        public DbSet<Category> Categories{ get; set; }

    }
}
