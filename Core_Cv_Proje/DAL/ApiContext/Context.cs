using Core_Cv_Proje.DAL.Entity;
using Microsoft.EntityFrameworkCore;

namespace Core_Cv_Proje.DAL.ApiContext
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=MONSTER2684TUNC\\SQLEXPRESS ; database=DbModCV2 ; integrated security=true");
        }

        public DbSet<Catagory>? Catagories { get; set; }

    }
}
