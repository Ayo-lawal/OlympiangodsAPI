global using Microsoft.EntityFrameworkCore;

namespace OlympiangodsAPI.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) 
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=DESKTOP-1MRF80N\\SQLEXPRESS;Database=Olympiangodsdb;Trusted_Connection=true;TrustServerCeertificate=true;");
            //"server=DESKTOP-1MRF80N\\SQLEXPRESS;database=metaproappDB;Trusted_Connection=True;"
        }

        public DbSet<Olympiangod> Olympiangods { get; set; }
    }
}
