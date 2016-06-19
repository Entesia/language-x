using System.Data.Entity;
using LX.Infrastructure;

namespace LX.Models
{
    public class LanguagesDbContext : DbContext
    {
        public LanguagesDbContext() : base("LanguagesDbContext")
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<LanguagesDbContext>());
        }

        protected override void OnModelCreating(DbModelBuilder builder)
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<LanguagesDbContext, Configuration>());
            base.OnModelCreating(builder);
        }

        public DbSet<Localization> Localizations { get; set; }
        public DbSet<Make> Makes { get; set; }
        public DbSet<Model> Models { get; set; }
        public DbSet<Car> Cars { get; set; } 
    }
}